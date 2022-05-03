/***********************************************************************
 * Module:	AppointmentService.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Service.AppointmentService
 ***********************************************************************/

using System;
using Model;
using System.IO;
using System.Collections.Generic;
using Repository;

namespace Service
{
	public class AppointmentService
	{
		public Boolean CreateApp(DateTime dateTime, String descripton, int duration, Boolean emergency, Patient patient, Doctor doctor, Room room)
		{
			int newID;
			if (File.Exists(idFile))
			{
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}
			else
				newID = 0;
			Appointment newAppointment = new Appointment(dateTime, descripton, duration, emergency, newID, patient, doctor, room);

			File.WriteAllText(idFile, newID.ToString());

			return appointmentRepository.Save(newAppointment);
		}
		
		public Boolean UpdateApp(DateTime dateTime, String descripton, int duration, Boolean emergency, Patient patient, Doctor doctor, Room room, int id)
		{
			Appointment appointment = appointmentRepository.FindByID(id);
			appointment.DateTime = dateTime;
			appointment.Descripton = descripton;
			appointment.Duration = duration;
			appointment.Emergency = emergency;
			appointment.Patient = patient;
			appointment.Doctor = doctor;
			appointment.Room = room;
			return appointmentRepository.UpdateByID(appointment);
		}
		
		public Boolean DeleteApp(int id)
		{
			return appointmentRepository.DeleteByID(id);
		}
		
		public Appointment ReadApp(int id)
		{
			return appointmentRepository.FindByID(id);
		}

		public Appointment ReadWithPriority(DateTime date)
        {
			return appointmentRepository.FindWithPriority(date);
        }

		public Appointment ReadWithPriorityDoctor(int id, DateTime date)
        {
			return appointmentRepository.FindWithPriorityDoctor(id, date);
        }

		public List<Appointment> ReadAll()
		{
			return appointmentRepository.FindAll();
		}


		public List<Appointment> ReadByDoctor (Doctor doctor)
        {
			return appointmentRepository.FindByDoctor(doctor);
        }


		public List<Appointment> ReadAllByPatientId(int id)
        {
			return appointmentRepository.FindAllByPatientId(id);
        }

		public List<Appointment> ReadAllByDoctorId(int id)
		{
			return appointmentRepository.FindAllByDoctorId(id);
		}

		public List<Appointment> ReadAllWithoutPatient()
		{
			return appointmentRepository.FindAllWithoutPatient();
		}


		public String idFile = @"..\..\..\Data\appointmentID.txt";
		public AppointmentRepository appointmentRepository = new AppointmentRepository();
	}
}
