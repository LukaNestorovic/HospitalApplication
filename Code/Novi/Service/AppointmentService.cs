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
using Serialization;

namespace Service
{
	public class AppointmentService
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
		public Boolean CreateAppointment(DateTime dateTime, String descripton, int duration, Boolean emergency, Patient patient, Doctor doctor, Room room, Boolean finished)
		{
			int newID = createId();
			Appointment newAppointment = new Appointment(dateTime, descripton, duration, emergency, newID, patient, doctor, room, finished);

			File.WriteAllText(idFile, newID.ToString());

			return appointmentRepository.Save(newAppointment);
		}
		
		public Boolean UpdateAppointment(DateTime dateTime, String descripton, int duration, Boolean emergency, Patient patient, Doctor doctor, Room room, int id, Boolean finished)
		{
			Appointment appointment = appointmentRepository.FindByID(id);
			appointment.DateTime = dateTime;
			appointment.Descripton = descripton;
			appointment.Duration = duration;
			appointment.Emergency = emergency;
			appointment.Patient = patient;
			appointment.Doctor = doctor;
			appointment.Room = room;
			appointment.Finished = finished;
			return appointmentRepository.UpdateByID(appointment);
		}
		
		public Boolean DeleteAppointment(int id)
		{
			return appointmentRepository.DeleteByID(id);
		}
		
		public Appointment ReadAppointment(int id)
		{
			return appointmentRepository.FindByID(id);
		}

		public Appointment ReadWithPriority(DateTime date)
        {
			List<Appointment> all = appointmentRepository.FindAll();
			List<Appointment> ret = new List<Appointment>();
			Appointment app = new Appointment();
			foreach (Appointment i in all)
			{
				if (i.Patient == null)
				{
					ret.Add(i);
				}
			}
			ret.Sort((y, x) => y.DateTime.CompareTo(x.DateTime));
			foreach (Appointment i in ret)
			{
				if (i.DateTime >= date)
				{
					app = i;
					break;
				}
			}
			return app;
		}

		public Appointment ReadWithPriorityDoctor(int id, DateTime date)
        {
			List<Appointment> all = appointmentRepository.FindAll();
			List<Appointment> ret = new List<Appointment>();
			Appointment app = new Appointment();
			foreach (Appointment i in all)
			{
				if (i.Patient == null)
				{
					ret.Add(i);
				}
			}
			ret.Sort((y, x) => y.DateTime.CompareTo(x.DateTime));
			foreach (Appointment i in ret)
			{
				if(i.Doctor == null)
                {
					continue;
                }
				if (i.DateTime >= date && i.Doctor.Id == id)
				{
					app = i;
					break;
				}
			}
			return app;
        }

		public List<Appointment> ReadAll()
		{
			return appointmentRepository.FindAll();
		}


		public List<Appointment> ReadByDoctor (Doctor doctor)
        {
			List<Appointment> all = appointmentRepository.FindAll();
			List<Appointment> appointments = new List<Appointment>();
			foreach (Appointment i in all)
			{
				if (i.Doctor == doctor)
				{
					appointments.Add(i);
				}
			}

			return appointments;
		}

		public List<Appointment> ReadIfFinished()
        {
			List<Appointment> all = appointmentRepository.FindAll();
			List<Appointment> appointments = new List<Appointment>();
			foreach (Appointment i in all)
			{
				if (i.Finished == true)
				{
					appointments.Add(i);
				}
			}

			return appointments;
		}

		public List<Appointment> ReadAllByDoctorId(int id)
        {
			try
			{
				List<Appointment> all = appointmentRepository.FindAll();
				List<Appointment> ret = new List<Appointment>();
				foreach (Appointment i in all)
				{
					if (i.Patient == null)
					{
						continue;
					}
					if (i.Patient.Id == id)
					{
						ret.Add(i);
					}
				}
				return ret;
			}
			catch
			{
				return null;
			}
		}

		public List<Appointment> ReadAllByPatientId(int id)
		{
			try
			{
				List<Appointment> all = appointmentRepository.FindAll();
				List<Appointment> ret = new List<Appointment>();
				foreach (Appointment i in all)
				{
					if (i.Patient == null)
					{
						continue;
					}
					if (i.Patient.Id == id && i.DateTime > DateTime.Now)
					{
						ret.Add(i);
					}
				}
				return ret;
			}
			catch
			{
				return null;
			}
		}

		public List<Appointment> ReadAllWithoutPatient()
		{
			List<Appointment> all = appointmentRepository.FindAll();
			List<Appointment> ret = new List<Appointment>();
			List<Appointment> retdate = new List<Appointment>();
			foreach (Appointment i in all)
			{
				if (i.Patient == null && i.DateTime > DateTime.Now)
				{
					ret.Add(i);
				}
			}
			ret.Sort((y, x) => y.DateTime.CompareTo(x.DateTime));
			return ret;
		}

		
		public String idFile = @"..\..\..\Data\appointmentID.txt";
		public AppointmentRepository appointmentRepository = new AppointmentRepository();
		public int id = 0;
	}
}
