/***********************************************************************
 * Module:	SavePatient.cs
 * Author:	lukaa
 * Purpose: Definition of the Class SavePatient
 ***********************************************************************/

using System;
using Appointments.Model;
using Appointments.Repository;
using System.IO;
using System.Collections.Generic;
using Serialization;
using Appointments.DTO;
using Interface;

namespace Appointments.Service
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
			Patient patient = new Patient(patientDTO.Name, patientDTO.Surname, patientDTO.Jmbg, patientDTO.Telephone, patientDTO.Email, patientDTO.BirthDate, patientDTO.Adress, patientDTO.InsuranceCarrier, patientDTO.Guest, false, newID,patientDTO.Password, 0, true);
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
			patient.First = patientDTO.First;
			return patientRepository.UpdateByID(patient);
		}

		public PatientDTO MakePatientDTO(PatientDTO patientDTO, Patient patient)
        {
			patientDTO.Name = patient.Name;
			patientDTO.Surname = patient.Surname;
			patientDTO.Jmbg = patient.Jmbg;
			patientDTO.Telephone = patient.Telephone;
			patientDTO.Email = patient.Email;
			patientDTO.BirthDate = patient.BirthDate;
			patientDTO.Adress = patient.Adress;
			patientDTO.InsuranceCarrier = patient.InsuranceCarrier;
			patientDTO.Guest = patient.Guest;
			patientDTO.Password = patient.Password;
			patientDTO.Blocked = patient.Blocked;
			patientDTO.Brojac= patient.Brojac;
			patientDTO.First = patient.First;
			return patientDTO;
		}
		
		public Boolean DeletePatient(int id)
		{
			return patientRepository.DeleteByID(id);
		}
		
		public Patient FindPatientById(int id)
		{
			return patientRepository.FindByID(id);
		}

		public Patient FindPatientByEmail(String email)
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

		public List<Patient> FindAll()
		{
			return patientRepository.FindAll();
		}

		public IPatientRepository patientRepository = new PatientRepository();
		public String idFile = @"..\..\..\Data\patientID.txt";
		public int id = 0;
	
	}
}
