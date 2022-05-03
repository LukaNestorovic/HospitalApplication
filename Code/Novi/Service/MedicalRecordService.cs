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
		public Boolean UpdateAllergies(int patientid, String allergies)
		{		
			MedicalRecord medicalRecord = medicalRecordRepository.FindByPatient(patientid);
			medicalRecord.Allergies = allergies;
			return medicalRecordRepository.UpdateByPatient(medicalRecord);
		}

		public Boolean UpdateAnamnesis(int patientid, String anamnesis)
		{
			MedicalRecord medicalRecord = medicalRecordRepository.FindByPatient(patientid);
			medicalRecord.Anamnesis = anamnesis;
			return medicalRecordRepository.UpdateByPatient(medicalRecord);
		}

		public Boolean CreateMR (String allergies, Patient patient, String anamnesis)
        {
			int newID;
			if (File.Exists(idFile))
			{
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}
			else
				newID = 0;
			MedicalRecord medicalRecord = new MedicalRecord(allergies, patient, newID, anamnesis);
			return medicalRecordRepository.Save(medicalRecord);
        }

		public String idFile = @"..\..\..\Data\medicalRecordID.txt";
		public MedicalRecordRepository medicalRecordRepository = new MedicalRecordRepository();
		public PatientRepository patientRepository = new PatientRepository();
	}
}
