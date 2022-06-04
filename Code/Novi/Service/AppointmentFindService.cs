﻿using System;
using Model;
using System.IO;
using System.Collections.Generic;
using Repository;
using Serialization;
using DTO;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using ProjekatSIMS;

namespace Service
{
    public class AppointmentFindService
    {
		public int patientId;
		public PatientService patientService = new PatientService();
		public AppointmentDTO appointmentDTO1 = new AppointmentDTO();
		public Patient patient;
		public Appointment appointment1;
		public PatientDTO patientDTO = new PatientDTO();
		public AppointmentRepository appointmentRepository = new AppointmentRepository();

		public Appointment FindWithDatePriority(DateTime date)
		{
			List<Appointment> all = appointmentRepository.FindAll();
			List<Appointment> ret = AppointmentListWithoutPatient(all);
			Appointment appointment = new Appointment();
			ret.Sort((y, x) => y.DateTime.CompareTo(x.DateTime));
			appointment = FindFirstFreeAppointment(ret, date);
			return appointment;
		}

		public Appointment FindFirstFreeAppointmentOfDoctor(List<Appointment> ret, DateTime date, int id)
		{
			Appointment appointment = new Appointment();
			foreach (Appointment i in ret)
			{
				if (i.Doctor == null)
				{
					continue;
				}
				if (i.DateTime >= date && i.Doctor.Id == id)
				{
					appointment = i;
					break;
				}
			}
			return appointment;
		}

		public Appointment FindWithDoctorPriority(int id, DateTime date)
		{
			List<Appointment> all = appointmentRepository.FindAll();
			List<Appointment> ret = AppointmentListWithoutPatient(all);
			ret.Sort((y, x) => y.DateTime.CompareTo(x.DateTime));
			return FindFirstFreeAppointmentOfDoctor(ret, date, id);
		}

		public Appointment FindFirstFreeAppointment(List<Appointment> ret, DateTime date)
		{
			Appointment appointment = new Appointment();
			foreach (Appointment i in ret)
			{
				if (i.DateTime >= date)
				{
					appointment = i;
					break;
				}
			}
			return appointment;
		}

		public List<Appointment> AppointmentListWithoutPatient(List<Appointment> all)
		{
			List<Appointment> ret = new List<Appointment>();
			foreach (Appointment i in all)
			{
				if (i.Patient == null)
				{
					ret.Add(i);
				}
			}
			return ret;
		}

		public List<Appointment> FindIfFinished()
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

		public List<Appointment> FindAllByDoctorId(int id)
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


		public List<Appointment> FindAllByPatientId(int id)
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

		public List<Appointment> FindAllWithoutPatient()
		{
			List<Appointment> all = appointmentRepository.FindAll();
			List<Appointment> ret = new List<Appointment>();
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
	}
}