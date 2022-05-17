using System;
using Service;
using Model;
using System.Collections.Generic;
using DTO;

namespace Controller
{
    public class DoctorSurveyController
    {
		public Boolean CreateDoctorSurvey(DoctorSurveyDTO doctorSurveyDTO)
		{
			return doctorSurveyService.CreateDoctorSurvey(doctorSurveyDTO);
		}

		public Boolean DeleteDoctorSurvey(int id)
		{
			return doctorSurveyService.DeleteDoctorSurvey(id);
		}

		public DoctorSurvey ReadDoctorSurvey(int id)
		{
			DoctorSurvey doctorSurvey = doctorSurveyService.ReadDoctorSurvey(id);
			return doctorSurvey;
		}

		public List<DoctorSurvey> ReadAll()
		{
			List<DoctorSurvey> doctorSurvey = doctorSurveyService.ReadAll();
			return doctorSurvey;
		}
		public Boolean UpdateDoctorSurvey(DoctorSurveyDTO doctorSurveyDTO, int id)
		{
			return doctorSurveyService.UpdateDoctorSurvey(doctorSurveyDTO, id);
		}

		public DoctorSurveyService doctorSurveyService = new DoctorSurveyService();
	}
}
