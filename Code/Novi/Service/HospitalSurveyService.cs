using System;
using Model;
using Repository;
using System.IO;
using System.Collections.Generic;
using DTO;

namespace Service
{
   public class HospitalSurveyService
    {
		public Boolean CreateHospitalSurvey(HospitalSurveyDTO hospitalSurveyDTO)
		{
			int newID;
			if (File.Exists(idFile))
			{
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}
			else
				newID = 0;
			HospitalSurvey newHospitalSurvey = new HospitalSurvey(hospitalSurveyDTO.Question1, hospitalSurveyDTO.Question2, hospitalSurveyDTO.Question3, newID, hospitalSurveyDTO.patient);

			File.WriteAllText(idFile, newID.ToString());

			return hospitalSurveyRepository.Save(newHospitalSurvey);
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

