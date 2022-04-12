/***********************************************************************
 * Module:	SavePatient.cs
 * Author:	lukaa
 * Purpose: Definition of the Class SavePatient
 ***********************************************************************/

using System;
using Model;
using Repository;
using System.IO;
using System.Collections.Generic;

namespace Service
{
	public class PatientService
	{
		public Boolean CreatePatient(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, String insuranceCarrier, Boolean guest) { 
			int newID;
			if(File.Exists(idFile)){
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}else
				newID = 0;
		
			Patient patient = new Patient(name, surname, jmbg, telephone, email, birthDate, adress, insuranceCarrier, guest, newID);

			return patientRepository.Save(patient);
		}
		
		public Boolean UpdatePatient(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, String insuranceCarrier, Boolean guest, int id)
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

		public List<Patient> ReadAll()
		{
			return patientRepository.FindAll();
		}

		public Repository.PatientRepository patientRepository = new PatientRepository();
		public String idFile = @"..\..\..\Data\patientID.txt";
	}
}
