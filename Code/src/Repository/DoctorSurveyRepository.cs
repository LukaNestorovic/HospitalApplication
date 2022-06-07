using System;
using System.Collections.Generic;
using Model;
using Serialization;
using Interface;

namespace Repository
{
    public class DoctorSurveyRepository : IDoctorSurveyRepository
    {
		public List<DoctorSurvey> FindAll()
		{
			return serializer.fromJSON(FileName);
		}

		public DoctorSurvey FindByID(int id)
		{
			List<DoctorSurvey> all = serializer.fromJSON(FileName);
			DoctorSurvey a = null;
			foreach (DoctorSurvey i in all)
			{
				if (i.Id == id)
				{
					a = i;
					break;
				}
			}
			return a;
		}

		public Boolean Save(DoctorSurvey doctorSurvey)
		{
			List<DoctorSurvey> all = serializer.fromJSON(FileName);
			all.Add(doctorSurvey);
			serializer.toJSON(FileName, all);
			return true;
		}

		public Boolean DeleteByID(int id)
		{
			List<DoctorSurvey> all = serializer.fromJSON(FileName);
			foreach (DoctorSurvey i in all)
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

		public Boolean UpdateByID(DoctorSurvey doctorSurvey)
		{
			List<DoctorSurvey> all = serializer.fromJSON(FileName);
			for (int i = 0; i < all.Count; i++)
			{
				if (all[i].Id == doctorSurvey.Id)
				{
					all[i] = doctorSurvey;
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return false;
		}

		private static String FileName = @"..\..\..\Data\DoctorSurveys.json";

		private static Serializer<DoctorSurvey> serializer = new Serializer<DoctorSurvey>();
	}
}
