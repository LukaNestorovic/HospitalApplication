using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serialization;
using Model;

namespace Repository
{
    public class MedicalRecordRepository
    {
		public Boolean UpdateByPatient(MedicalRecord medicalRecord)
		{
			List<MedicalRecord> all = serializer.fromJSON(FileName);
			for (int i = 0; i < all.Count; i++)
			{
				if (all[i].patient.Id == medicalRecord.patient.Id)
				{
					all[i] = medicalRecord;
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return false;
		}

		public MedicalRecord FindByPatient(int patientid)
		{
			List<MedicalRecord> all = serializer.fromJSON(FileName);
			MedicalRecord a = null;
			foreach (MedicalRecord i in all)
			{
				if (i.patient.Id == patientid)
				{
					a = i;
					break;
				}
			}
			return a;
		}

		public Boolean Save(MedicalRecord medicalRecord)
		{
			List<MedicalRecord> all = serializer.fromJSON(FileName);
			all.Add(medicalRecord);
			serializer.toJSON(FileName, all);
			return true;
		}

		public List<MedicalRecord> FindAll()
		{
			return serializer.fromJSON(FileName);
		}

		private static String FileName = @"..\..\..\Data\MedicalRecords.json";

		private static Serializer<MedicalRecord> serializer = new Serializer<MedicalRecord>();
	}
}
