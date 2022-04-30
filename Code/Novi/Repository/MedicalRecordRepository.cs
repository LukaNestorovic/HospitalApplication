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

		private static String FileName = @"..\..\..\data\MedicalRecords.json";

		private static Serializer<MedicalRecord> serializer = new Serializer<MedicalRecord>();
	}
}
