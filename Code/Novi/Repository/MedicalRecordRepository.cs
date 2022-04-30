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
				if (all[i].patient == medicalRecord.patient)
				{
					all[i] = medicalRecord;
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return false;
		}

		public MedicalRecord FindByPatient(Patient patient)
		{
			List<MedicalRecord> all = serializer.fromJSON(FileName);
			MedicalRecord a = null;
			foreach (MedicalRecord i in all)
			{
				if (i.patient == patient)
				{
					a = i;
					break;
				}
			}
			return a;
		}

		private static String FileName = @"..\..\..\data\MedicalRecords.json";

		private static Serializer<MedicalRecord> serializer = new Serializer<MedicalRecord>();
	}
}
