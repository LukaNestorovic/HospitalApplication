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
using DTO;

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
		public Boolean CreatePatient(PatientDTO patientDTO) {
			int newID = createId();
			Patient patient = new Patient(patientDTO.Name, patientDTO.Surname, patientDTO.Jmbg, patientDTO.Telephone, patientDTO.Email, patientDTO.BirthDate, patientDTO.Adress, patientDTO.InsuranceCarrier, patientDTO.Guest, false, newID,patientDTO.Password, 0);
			return patientRepository.Save(patient);
		}
		
		public Boolean UpdatePatient(PatientDTO patientDTO, int id)
		{
			Patient patient = patientRepository.FindByID(id);
			patient.Name = patientDTO.Name;
			patient.Surname = patientDTO.Surname;
			patient.Jmbg = patientDTO.Jmbg;
			patient.Telephone = patientDTO.Telephone;
			patient.Email = patientDTO.Email;
			patient.BirthDate = patientDTO.BirthDate;
			patient.Adress = patientDTO.Adress;
			patient.InsuranceCarrier = patientDTO.InsuranceCarrier;
			patient.Guest = patientDTO.Guest;
			patient.Password = patientDTO.Password;
			patient.Blocked = patientDTO.Blocked;
			patient.Brojac = patientDTO.Brojac;
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
