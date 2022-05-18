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
using Serialization;

namespace Service
{
	public class DoctorService
	{
		public Boolean CreateDoctor(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, String speciality, float grade, int salary, String password)
		{
			int newID;
			if(File.Exists(idFile)){
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}else
				newID = 0;
			

			Doctor doctor = new Doctor(name, surname, jmbg, telephone, email, birthDate, adress, speciality, grade, salary, newID, password);

			return doctorRepository.Save(doctor);
		}
		
		public Boolean UpdateDoctor(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, String speciality, float grade, int salary, int id, String password)
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
			doctor.Password = password;
			return doctorRepository.UpdateByID(doctor);
		}
		
		public Boolean DeleteDoctor(int id)
		{
			return doctorRepository.DeleteByID(id);
		}

		public Doctor ReadDoctorByEmail(String email)
		{
			List<Doctor> all = serializer.fromJSON(FileName);
			Doctor a = null;
			foreach (Doctor i in all)
			{
				if (i.Email == email)
				{
					a = i;
					break;
				}
			}
			return a;
		}

		public List<Doctor> ReadDoctorsBySpecialityAndFreeAppointment(String speciality)
		{
			List<Doctor> all = serializer.fromJSON(FileName);
			List<Doctor> specialDoctors = new List<Doctor>();
			List<Doctor> specialDoctorsFree = new List<Doctor>();

			foreach (Doctor i in all)
			{
				if (i.Specialty == speciality)
				{
					specialDoctors.Add(i);
				}
			}
			foreach(Doctor i in specialDoctors)
            {
                List<Appointment> appointments = appointmentService.ReadAllByDoctorId(i.Id);

                Boolean a = new Boolean();
				foreach (Appointment appointment in appointments)
                {
					if(!(appointment.DateTime > DateTime.Now && appointment.DateTime < DateTime.Now.AddHours(2)) == false)
                    {
						a = false;
						break;
                    }
					a = true;
                }
				if (a == true)
					specialDoctorsFree.Add(i);
            }
			return specialDoctorsFree;
		}

		public List<Doctor> ReadDoctorsBySpecialityAndFreeOperation(String speciality)
		{
			List<Doctor> all = serializer.fromJSON(FileName);
			List<Doctor> specialDoctors = new List<Doctor>();
			List<Doctor> specialDoctorsFree = new List<Doctor>();

			foreach (Doctor i in all)
			{
				if (i.Specialty == speciality)
				{
					specialDoctors.Add(i);
				}
			}
			foreach (Doctor i in specialDoctors)
			{
				List<Operation> operations = operationRepository.ReadAllByDoctorId(i.Id);
				Boolean a = new Boolean();
				foreach (Operation operation in operations)
				{
					if (!(operation.DateTime > DateTime.Now && operation.DateTime < DateTime.Now.AddHours(2)) == false)
					{
						a = false;
						break;
					}
					a = true;
				}
				if (a == true)
					specialDoctorsFree.Add(i);
			}
			return specialDoctorsFree;
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
		private static String FileName = @"..\..\..\data\Doctors.json";
		public AppointmentService appointmentService = new AppointmentService();
		public OperationRepository operationRepository = new OperationRepository();

		private static Serializer<Doctor> serializer = new Serializer<Doctor>();

	}
}
