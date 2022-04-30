using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Service
{
    public class MedicalRecordService
    {
		public Boolean UpdateAlergenes(Patient patient, String allergies)
		{
			MedicalRecord medicalRecord = medicalRecordRepository.FindByPatient(patient);
			medicalRecord.Allergies = allergies;
			return medicalRecordRepository.UpdateByPatient(medicalRecord);
		}

		public MedicalRecordRepository medicalRecordRepository = new MedicalRecordRepository();
	}
}
