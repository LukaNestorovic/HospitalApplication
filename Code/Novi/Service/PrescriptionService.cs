using System;
using Model;
using System.IO;
using System.Collections.Generic;
using Repository;
using System.Collections;


namespace Service
{
    public class PrescriptionService
    {
		public Boolean CreatePrescription(String instructions, Doctor doctor, Patient patient, ArrayList drug, DateTime datetime)
		{
			int newID;
			if (File.Exists(idFile))
			{
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}
			else
				newID = 0;
			
			Prescription newPrescription = new Prescription(instructions, newID, doctor, patient, drug, datetime);


			File.WriteAllText(idFile, newID.ToString());

			return prescriptionRepository.Save(newPrescription);
			
		}


		public String idFile = @"..\..\..\Data\prescriptionID.txt";
		public PrescriptionRepository prescriptionRepository = new PrescriptionRepository();
		public DoctorRepository doctorRepository = new DoctorRepository();
		public PatientRepository patientRepository = new PatientRepository();
    }
}
