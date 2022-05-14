using System;
using Model;
using System.IO;
using System.Collections.Generic;
using Repository;
using System.Collections;
using Serialization;
using System.Windows;


namespace Service
{
    public class PrescriptionService
    {
		public Boolean CreatePrescription(String instructions, Doctor doctor, Patient patient, Drug drug, DateTime datetime)
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

		public List<Prescription> ReadAllByPatientId(int id)
		{
            List<Prescription> all = serializer.fromJSON(FileName);
            List<Prescription> ret = new List<Prescription>();
            foreach (Prescription i in all)
            {
                if (i.patient == null)
                {
                    continue;
                }
                if (i.patient.Id == id)
                {
                    ret.Add(i);
                }
            }
            foreach (Prescription i in ret)
            {
                DateTime now = DateTime.Now;
                TimeSpan value = i.datetime.Subtract(now);
                if (value.TotalMinutes < 15 && value.TotalMinutes > 0)
                {
                    MessageBox.Show("Za manje od 15 minuta treba da popijete lek " + i.drug.Name, "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            return ret;
        }


		public String idFile = @"..\..\..\Data\prescriptionID.txt";
		public PrescriptionRepository prescriptionRepository = new PrescriptionRepository();
		public DoctorRepository doctorRepository = new DoctorRepository();
		public PatientRepository patientRepository = new PatientRepository();
        private static String FileName = @"..\..\..\data\Prescriptions.json";

        private static Serializer<Prescription> serializer = new Serializer<Prescription>();
    }
}
