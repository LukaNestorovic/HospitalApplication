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
using DTO;

namespace Service
{
	public class AppointmentService
	{
		public int patientId;
		public PatientService patientService = new PatientService();
		public AppointmentDTO appointmentDTO1 = new AppointmentDTO();
		public Patient patient;
		public Appointment appointment1;
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
		public Boolean CreateAppointment(AppointmentDTO appointmentDTO)
		{
			int newID = createId();
			Appointment newAppointment = new Appointment(appointmentDTO.DateTime, appointmentDTO.Descripton, appointmentDTO.Duration, appointmentDTO.Emergency, newID, appointmentDTO.Patient, appointmentDTO.Doctor, appointmentDTO.Room, appointmentDTO.Finished);

			File.WriteAllText(idFile, newID.ToString());

			return appointmentRepository.Save(newAppointment);
		}
		
		public Boolean UpdateAppointment(AppointmentDTO appointmentDTO, int id)
		{
			appointmentDTO.Patient.Brojac++;
			Appointment appointment = appointmentRepository.FindByID(id);
			appointment.DateTime = appointmentDTO.DateTime;
			appointment.Descripton = appointmentDTO.Descripton;
			appointment.Duration = appointmentDTO.Duration;
			appointment.Emergency = appointmentDTO.Emergency;
			appointment.Doctor = appointmentDTO.Doctor;
			appointment.Room = appointmentDTO.Room;
			appointment.Finished = appointmentDTO.Finished;
			patientId = appointmentDTO.Patient.Id;
			if (appointmentDTO.Patient.Brojac > 4)
			{
				patientService.UpdatePatient(appointmentDTO.Patient.Name, appointmentDTO.Patient.Surname, appointmentDTO.Patient.Jmbg, appointmentDTO.Patient.Telephone, appointmentDTO.Patient.Email, appointmentDTO.Patient.BirthDate, appointmentDTO.Patient.Adress, appointmentDTO.Patient.InsuranceCarrier, appointmentDTO.Patient.Guest, true, patientId, appointmentDTO.Patient.Password, appointmentDTO.Patient.Brojac);
				Patient patient1 = patientService.ReadPatient(patientId);
				appointment.Patient = patient1;
				return appointmentRepository.UpdateByID(appointment);
			}
			patientService.UpdatePatient(appointmentDTO.Patient.Name, appointmentDTO.Patient.Surname, appointmentDTO.Patient.Jmbg, appointmentDTO.Patient.Telephone, appointmentDTO.Patient.Email, appointmentDTO.Patient.BirthDate, appointmentDTO.Patient.Adress, appointmentDTO.Patient.InsuranceCarrier, appointmentDTO.Patient.Guest, appointmentDTO.Patient.Blocked, patientId, appointmentDTO.Patient.Password, appointmentDTO.Patient.Brojac);
			Patient patient = patientService.ReadPatient(patientId);
			appointment.Patient = patient;

			return appointmentRepository.UpdateByID(appointment);
		}
		
		public Boolean DeleteAppointment(int id, int patientId)
		{
			Patient patient = patientService.ReadPatient(1);
			patient.Brojac++;
			if(patient.Brojac > 4)
            {
				patientService.UpdatePatient(patient.Name, patient.Surname, patient.Jmbg, patient.Telephone, patient.Email, patient.BirthDate, patient.Adress, patient.InsuranceCarrier, patient.Guest, true, patient.Id, patient.Password, patient.Brojac);
				Patient patient1 = patientService.ReadPatient(patient.Id);
				return appointmentRepository.DeleteByID(id);
			}
			patientService.UpdatePatient(patient.Name, patient.Surname, patient.Jmbg, patient.Telephone, patient.Email, patient.BirthDate, patient.Adress, patient.InsuranceCarrier, patient.Guest, true, patient.Id, patient.Password, patient.Brojac);
			Patient patient2 = patientService.ReadPatient(patient.Id);
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
		

		public List<Appointment> ReadAllByPatientId(int id)
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

		public List<Appointment> ReadAllWithoutPatient()
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

		
		public String idFile = @"..\..\..\Data\appointmentID.txt";
		public AppointmentRepository appointmentRepository = new AppointmentRepository();
		public int id = 0;
	}
}
