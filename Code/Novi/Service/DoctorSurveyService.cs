using System;
using Model;
using Repository;
using System.IO;
using System.Collections.Generic;

namespace Service
{
    public class DoctorSurveyService
    {
		public Boolean CreateDoctorSurvey(int question1, int question2, int question3, Patient patient, Doctor doctor)
		{
			int newID;
			if (File.Exists(idFile))
			{
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}
			else
				newID = 0;
			DoctorSurvey newDoctorSurvey = new DoctorSurvey(newID, question1, question2, question3, patient, doctor);

			File.WriteAllText(idFile, newID.ToString());

			return doctorSurveyRepository.Save(newDoctorSurvey);
		}

		public Boolean UpdateDoctorSurvey(int question1, int question2, int question3, Patient patient, Doctor doctor,int id)
		{
			DoctorSurvey doctorSurvey = doctorSurveyRepository.FindByID(id);
			doctorSurvey.Question1 = question1;
			doctorSurvey.Question2 = question2;
			doctorSurvey.Question3 = question3;
			doctorSurvey.patient = patient;
			doctorSurvey.doctor = doctor;
			return doctorSurveyRepository.UpdateByID(doctorSurvey);
		}

		public Boolean DeleteDoctorSurvey(int id)
		{
			return doctorSurveyRepository.DeleteByID(id);
		}

		public DoctorSurvey ReadDoctorSurvey(int id)
		{
			return doctorSurveyRepository.FindByID(id);
		}

		public List<DoctorSurvey> ReadAll()
		{
			return doctorSurveyRepository.FindAll();
		}

		public DoctorSurveyRepository doctorSurveyRepository = new DoctorSurveyRepository();
		public String idFile = @"..\..\..\Data\doctorSurveyID.txt";
	}
}
