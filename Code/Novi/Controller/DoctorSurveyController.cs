using System;
using Service;
using Model;
using System.Collections.Generic;

namespace Controller
{
    public class DoctorSurveyController
    {
		public Boolean CreateDoctorSurvey(int question1, int question2, int question3, Patient patient, Doctor doctor)
		{
			return doctorSurveyService.CreateDoctorSurvey(question1, question2, question3, patient, doctor);
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
		public Boolean UpdateDoctorSurvey(int question1, int question2, int question3, Patient patient, Doctor doctor, int id)
		{
			return doctorSurveyService.UpdateDoctorSurvey(question1, question2, question3, patient, doctor,id);
		}

		public DoctorSurveyService doctorSurveyService = new DoctorSurveyService();
	}
}
