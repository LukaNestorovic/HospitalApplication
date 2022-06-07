using System;
using System.Collections.Generic;
using Model;
using Serialization;
using Interface;

namespace Repository
{
    public class HospitalSurveyRepository : IHospitalSurveyRepository
    {
        public List<HospitalSurvey> FindAll()
        {
            return serializer.fromJSON(FileName);
        }

		public HospitalSurvey FindByID(int id)
		{
			List<HospitalSurvey> all = serializer.fromJSON(FileName);
			HospitalSurvey a = null;
			foreach (HospitalSurvey i in all)
			{
				if (i.Id == id)
				{
					a = i;
					break;
				}
			}
			return a;
		}

		public Boolean Save(HospitalSurvey hospitalSurvey)
		{
			List<HospitalSurvey> all = serializer.fromJSON(FileName);
			all.Add(hospitalSurvey);
			serializer.toJSON(FileName, all);
			return true;
		}

		public Boolean DeleteByID(int id)
		{
			List<HospitalSurvey> all = serializer.fromJSON(FileName);
			foreach (HospitalSurvey i in all)
			{
				if (i.Id == id)
				{
					all.Remove(i);
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return true;
		}

		public Boolean UpdateByID(HospitalSurvey hospitalSurvey)
		{
			List<HospitalSurvey> all = serializer.fromJSON(FileName);
			for (int i = 0; i < all.Count; i++)
			{
				if (all[i].Id == hospitalSurvey.Id)
				{
					all[i] = hospitalSurvey;
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return false;
		}

		private static String FileName = @"..\..\..\Data\HospitalSurveys.json";

		private static Serializer<HospitalSurvey> serializer = new Serializer<HospitalSurvey>();
	}
}
