/***********************************************************************
 * Module:	AppointmentService.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Service.AppointmentService
 ***********************************************************************/

using System;
using Model;
using System.IO;

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
			appointment.patient = patient;
			appointment.doctor = doctor;
			appointment.room = room;
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
	
		public Repository.AppointmentRepository appointmentRepository;
		public static String idFile = "appointmentID.txt";
	}
}
