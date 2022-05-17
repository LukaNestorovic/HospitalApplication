using System;
using Model;
using Repository;
using System.IO;
using System.Collections.Generic;
using DTO;

namespace Service
{
    public class DoctorSurveyService
    {
		public Boolean CreateDoctorSurvey(DoctorSurveyDTO doctorSurveyDTO)
		{
			int newID;
			if (File.Exists(idFile))
			{
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}
			else
				newID = 0;
			DoctorSurvey newDoctorSurvey = new DoctorSurvey(newID, doctorSurveyDTO.Question1, doctorSurveyDTO.Question2, doctorSurveyDTO.Question3, doctorSurveyDTO.patient, doctorSurveyDTO.doctor);

			File.WriteAllText(idFile, newID.ToString());

			return doctorSurveyRepository.Save(newDoctorSurvey);
		}

		public Boolean UpdateDoctorSurvey(DoctorSurveyDTO doctorSurveyDTO, int id)
		{
			DoctorSurvey doctorSurvey = doctorSurveyRepository.FindByID(id);
			doctorSurvey.Question1 = doctorSurveyDTO.Question1;
			doctorSurvey.Question2 = doctorSurveyDTO.Question2;
			doctorSurvey.Question3 = doctorSurveyDTO.Question3;
			doctorSurvey.patient = doctorSurveyDTO.patient;
			doctorSurvey.doctor = doctorSurveyDTO.doctor;
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
