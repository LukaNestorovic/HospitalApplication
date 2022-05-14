using System;
using Service;
using Model;
using System.Collections.Generic;

namespace Controller
{
    public class HospitalSurveyController
    {
		public Boolean CreateHospitalSurvey(int question1, int question2, int question3, Patient patient)
		{
			return hospitalSurveyService.CreateHospitalSurvey(question1, question2, question3, patient);
		}

		public Boolean DeleteHospitalSurvey(int id)
		{
			return hospitalSurveyService.DeleteHospitalSurvey(id);
		}

		public HospitalSurvey ReadHospitalSurvey(int id)
		{
			HospitalSurvey hospitalSurvey = hospitalSurveyService.ReadHospitalSurvey(id);
			return hospitalSurvey;
		}

		public List<HospitalSurvey> ReadAll()
		{
			List<HospitalSurvey> hospitalSurvey = hospitalSurveyService.ReadAll();
			return hospitalSurvey;
		}
		public Boolean UpdateHospitalSurvey(int question1, int question2, int question3, Patient patient, int id)
		{
			return hospitalSurveyService.UpdateHospitalSurvey(question1,question2, question3, patient, id);
		}

		public HospitalSurveyService hospitalSurveyService = new HospitalSurveyService();
	}
}
