/***********************************************************************
 * Module:	SavePatient.cs
 * Author:	lukaa
 * Purpose: Definition of the Class SavePatient
 ***********************************************************************/

using System;
using Model;
using Repository;
using System.IO;

namespace Service
{
	public class PatientService
	{
		public Boolean CreatePatient(string name, string surname, string jmbg, string telephone, string email, DateTime birthDate, string adress, string insuranceCarrier, bool guest)
			int newID;
			if(File.Exists(idFile)){
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}else
				newID = 0;
		{
			Patient patient = new Patient(name, surname, jmbg, telephone, email, birthDate, adress, insuranceCarrier, guest, newID);

			return patientRepository.Save(patient);
		}
		
		public Boolean UpdatePatient(string name, string surname, string jmbg, string telephone, string email, DateTime birthDate, string adress, string insuranceCarrier, bool guest, int id)
		{
			Patient patient = patientRepository.FindByID(id);
			patient.Name = name;
			patient.Surname = surname;
			patient.Jmbg = jmbg;
			patient.Telephone = telephone;
			patient.Email = email;
			patient.BirthDate = birthDate;
			patient.Adress = adress;
			patient.InsuranceCarrier = insuranceCarrier;
			patient.Guest = guest;
			return patientRepository.UpdateByID(patient);
		}
		
		public Boolean DeletePatient(int id)
		{
			return patientRepository.DeleteByID(id);
		}
		
		public Patient ReadPatient(int id)
		{
			return patientRepository.FindByID(id);
		}
	
		public Repository.PatientRepository patientRepository = new PatientRepository();
		public static String idFile = "operationID.txt";
	}
}
