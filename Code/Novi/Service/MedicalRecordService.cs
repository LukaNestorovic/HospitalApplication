using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;
using System.IO;

namespace Service
{
    public class MedicalRecordService
    {
		public Boolean UpdateAllergies(Patient patient, String allergies)
		{
			MedicalRecord medicalRecord = medicalRecordRepository.FindByPatient(patient);
			medicalRecord.Allergies = allergies;
			return medicalRecordRepository.UpdateByPatient(medicalRecord);
		}

		public Boolean CreateMR (String allergies, Patient patient)
        {
			int newID;
			if (File.Exists(idFile))
			{
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}
			else
				newID = 0;
			MedicalRecord medicalRecord = new MedicalRecord(allergies, patient, newID);
			return medicalRecordRepository.Save(medicalRecord);
        }

		public String idFile = @"..\..\..\Data\medicalRecordID.txt";
		public MedicalRecordRepository medicalRecordRepository = new MedicalRecordRepository();
	}
}
