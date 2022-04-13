/***********************************************************************
 * Module:	SaveDoctor.cs
 * Author:	lukaa
 * Purpose: Definition of the Class SaveDoctor
 ***********************************************************************/

using System;
using Model;
using System.Collections.Generic;
using System.IO;
using Repository;

namespace Service
{
	public class DoctorService
	{
		public Boolean CreateDoctor(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, String speciality, float grade, int salary)
		{
			int newID;
			if(File.Exists(idFile)){
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}else
				newID = 0;
			
			Doctor doctor = new Doctor(name, surname, jmbg, telephone, email, birthDate, adress, speciality, grade, salary, newID);
			return doctorRepository.Save(doctor);
		}
		
		public Boolean UpdateDoctor(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, String speciality, float grade, int salary, int id)
		{
			Doctor doctor = doctorRepository.FindByID(id);
			doctor.Name = name;
			doctor.Surname = surname;
			doctor.Jmbg = jmbg;
			doctor.Telephone = telephone;
			doctor.Email = email;
			doctor.BirthDate = birthDate;
			doctor.Adress = adress;
			doctor.Specialty = speciality;
			doctor.Grade = grade;
			doctor.Salary = salary;
			return doctorRepository.UpdateByID(doctor);
		}
		
		public Boolean DeleteDoctor(int id)
		{
			return doctorRepository.DeleteByID(id);
		}
		
		public Doctor ReadDoctor(int id)
		{
			return doctorRepository.FindByID(id);
		}
		
		public List<Doctor> ReadAll()
		{
			return doctorRepository.FindAll();
		}
	
		public Repository.DoctorRepository doctorRepository = new DoctorRepository();
		public String idFile = @"..\..\..\Data\doctorID.txt";

	}
}
