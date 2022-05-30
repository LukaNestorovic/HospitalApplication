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
using Serialization;

namespace Service
{
	public class PatientService
	{
		public int createId()
		{
			int newID;
			if (File.Exists(idFile))
			{
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}
			else
				newID = 0;
			File.Create(idFile).Close();
			File.WriteAllText(idFile, newID.ToString());
			id = newID;
			return newID;
		}
		public Boolean CreatePatient(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, String insuranceCarrier, Boolean guest, String password, int brojac) {
			int newID = createId();
			Patient patient = new Patient(name, surname, jmbg, telephone, email, birthDate, adress, insuranceCarrier, guest, false, newID, password, 0);


			return patientRepository.Save(patient);
		}
		
		public Boolean UpdatePatient(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, String insuranceCarrier, Boolean guest, Boolean blocked, int id, String password, int brojac)
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
			patient.Password = password;
			patient.Blocked = blocked;
			patient.Brojac = brojac;
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

		public Patient ReadPatientByEmail(String email)
		{
			List<Patient> all = patientRepository.FindAll(); ;
			Patient a = null;
			foreach (Patient i in all)
			{
				if (i.Email == email)
				{
					a = i;
					break;
				}
			}
			return a;
		}

		public List<Patient> ReadAll()
		{
			return patientRepository.FindAll();
		}

		public PatientRepository patientRepository = new PatientRepository();
		public String idFile = @"..\..\..\Data\patientID.txt";
		public int id = 0;
	
	}
}
