using System;
using Service;
using Model;
using System.Collections.Generic;
using DTO;

namespace Controller
{
    public class HospitalSurveyController
    {
		public Boolean CreateHospitalSurvey(HospitalSurveyDTO hospitalSurveyDTO)
		{
			return hospitalSurveyService.CreateHospitalSurvey(hospitalSurveyDTO);
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

		public HospitalSurveyService hospitalSurveyService = new HospitalSurveyService();
	}
}
