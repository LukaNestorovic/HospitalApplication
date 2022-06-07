using System;
using Appointments.Model;
using System.IO;
using System.Collections.Generic;
using Appointments.Repository;
using Serialization;
using Appointments.DTO;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using ProjekatSIMS;

namespace Appointments.Service
{
    public class AppointmentFindService
    {
		public int patientId;
		public PatientService patientService = new PatientService();
		public AppointmentDTO appointmentDTO1 = new AppointmentDTO();
		public Patient patient;
		public Model.Appointment appointment1;
		public PatientDTO patientDTO = new PatientDTO();
		public AppointmentRepository appointmentRepository = new AppointmentRepository();

		public Model.Appointment FindWithDatePriority(DateTime date)
		{
			List<Model.Appointment> all = appointmentRepository.FindAll();
			List<Model.Appointment> ret = AppointmentListWithoutPatient(all);
			Model.Appointment appointment = new Model.Appointment();
			ret.Sort((y, x) => y.DateTime.CompareTo(x.DateTime));
			appointment = FindFirstFreeAppointment(ret, date);
			return appointment;
		}

		public Model.Appointment FindFirstFreeAppointmentOfDoctor(List<Model.Appointment> ret, DateTime date, int id)
		{
			Model.Appointment appointment = new Model.Appointment();
			foreach (Model.Appointment i in ret)
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

		public Model.Appointment FindWithDoctorPriority(int id, DateTime date)
		{
			List<Model.Appointment> all = appointmentRepository.FindAll();
			List<Model.Appointment> ret = AppointmentListWithoutPatient(all);
			ret.Sort((y, x) => y.DateTime.CompareTo(x.DateTime));
			return FindFirstFreeAppointmentOfDoctor(ret, date, id);
		}

		public Model.Appointment FindFirstFreeAppointment(List<Model.Appointment> ret, DateTime date)
		{
			Model.Appointment appointment = new Model.Appointment();
			foreach (Model.Appointment i in ret)
			{
				if (i.DateTime >= date)
				{
					appointment = i;
					break;
				}
			}
			return appointment;
		}

		public List<Model.Appointment> AppointmentListWithoutPatient(List<Model.Appointment> all)
		{
			List<Model.Appointment> ret = new List<Model.Appointment>();
			foreach (Model.Appointment i in all)
			{
				if (i.Patient == null)
				{
					ret.Add(i);
				}
			}
			return ret;
		}

		public List<Model.Appointment> FindAllFinished()
		{
			List<Model.Appointment> all = appointmentRepository.FindAll();
			List<Model.Appointment> appointments = new List<Model.Appointment>();
			foreach (Model.Appointment i in all)
			{
				if (i.Finished == true)
				{
					appointments.Add(i);
				}
			}
			return appointments;
		}

		public List<Model.Appointment> FindAllByDoctorId(int id)
		{
			List<Model.Appointment> all = appointmentRepository.FindAll();
			List<Model.Appointment> ret = new List<Model.Appointment>();
			foreach (Model.Appointment i in all)
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


		public List<Model.Appointment> FindAllByPatientId(int id)
		{
			List<Model.Appointment> all = appointmentRepository.FindAll();
			List<Model.Appointment> ret = new List<Model.Appointment>();
			foreach (Model.Appointment i in all)
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

		public List<Model.Appointment> FindAllWithoutPatient()
		{
			List<Model.Appointment> all = appointmentRepository.FindAll();
			List<Model.Appointment> ret = new List<Model.Appointment>();
			foreach (Model.Appointment i in all)
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
