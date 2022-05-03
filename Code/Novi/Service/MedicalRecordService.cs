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

		public Boolean CreateAnamnesis (Patient patient, String anamnesis, String allergies)
        {
			int newID;
			if (File.Exists(idFile))
			{
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}
			else
				newID = 0;
			MedicalRecord medicalRecord = new MedicalRecord( patient, newID, anamnesis, allergies);
			return medicalRecordRepository.Save(medicalRecord);
        }

		public List<MedicalRecord> ReadAll()
        {
			return medicalRecordRepository.FindAll();
        }

		public String idFile = @"..\..\..\Data\medicalRecordID.txt";
		public MedicalRecordRepository medicalRecordRepository = new MedicalRecordRepository();
		public PatientRepository patientRepository = new PatientRepository();
	}
}
