using System;
using Model;
using Repository;
using System.IO;
using System.Collections.Generic;

namespace Service
{
   public class HospitalSurveyService
    {
		public Boolean CreateHospitalSurvey(int question1, int question2, int question3, Patient patient)
		{
			int newID;
			if (File.Exists(idFile))
			{
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}
			else
				newID = 0;
			HospitalSurvey newHospitalSurvey = new HospitalSurvey(question1, question2, question3, newID, patient);

			File.WriteAllText(idFile, newID.ToString());

			return hospitalSurveyRepository.Save(newHospitalSurvey);
		}

		public Boolean UpdateHospitalSurvey(int question1, int question2, int question3, Patient patient, int id)
		{
			HospitalSurvey hospitalSurvey = hospitalSurveyRepository.FindByID(id);
			hospitalSurvey.Question1 = question1;
			hospitalSurvey.Question2 = question2;
			hospitalSurvey.Question3 = question3;
			hospitalSurvey.patient = patient;
			return hospitalSurveyRepository.UpdateByID(hospitalSurvey);
		}

		public Boolean DeleteHospitalSurvey(int id)
		{
			return hospitalSurveyRepository.DeleteByID(id);
		}

		public HospitalSurvey ReadHospitalSurvey(int id)
		{
			return hospitalSurveyRepository.FindByID(id);
		}

		public List<HospitalSurvey> ReadAll()
		{
			return hospitalSurveyRepository.FindAll();
		}

		public HospitalSurveyRepository hospitalSurveyRepository = new HospitalSurveyRepository();
		public String idFile = @"..\..\..\Data\hospitalSurveyID.txt";
	}
}

