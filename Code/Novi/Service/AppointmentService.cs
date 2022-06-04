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
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using ProjekatSIMS;

namespace Service
{
	public class AppointmentService
	{
		public int patientId;
		public PatientService patientService = new PatientService();
		public AppointmentDTO appointmentDTO1 = new AppointmentDTO();
		public Patient patient;
		public Appointment appointment1;
		public PatientDTO patientDTO = new PatientDTO();
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
			Appointment newAppointment = new Appointment(appointmentDTO.DateTime, appointmentDTO.Descripton, appointmentDTO.Duration, appointmentDTO.Emergency, newID, appointmentDTO.Patient, appointmentDTO.Doctor, appointmentDTO.Room, appointmentDTO.Finished, appointmentDTO.Anamnesis, appointmentDTO.Comment);

			File.WriteAllText(idFile, newID.ToString());

			return appointmentRepository.Save(newAppointment);
		}

		public Appointment AppointmentFromDTO(AppointmentDTO appointmentDTO, Appointment appointment)
        {
			appointment.DateTime = appointmentDTO.DateTime;
			appointment.Descripton = appointmentDTO.Descripton;
			appointment.Duration = appointmentDTO.Duration;
			appointment.Emergency = appointmentDTO.Emergency;
			appointment.Doctor = appointmentDTO.Doctor;
			appointment.Room = appointmentDTO.Room;
			appointment.Finished = appointmentDTO.Finished;
			appointment.Anamnesis = appointmentDTO.Anamnesis;
			appointment.Comment = appointmentDTO.Comment;
			return appointment;
		}
		
		public Boolean UpdateAppointment(AppointmentDTO appointmentDTO, int id)
        {
			Appointment appointment = appointmentRepository.FindByID(id);
			appointment = AppointmentFromDTO(appointmentDTO, appointment);
			return appointmentRepository.UpdateByID(appointment);
		}

		public Boolean UpdateAppointmentAntiTroll(AppointmentDTO appointmentDTO, int id)
		{
			Appointment appointment = appointmentRepository.FindByID(id);
			appointment = AppointmentFromDTO(appointmentDTO, appointment);
			patientDTO = patientService.MakePatientDTO(patientDTO, appointment.Patient);
			patientDTO.Brojac++;
			appointment.Patient.Brojac = patientDTO.Brojac;
			if (patientDTO.Brojac > 4)
			{
				patientDTO.Blocked = true;
				patientService.UpdatePatient(patientDTO, appointmentDTO.Patient.Id);
				MessageBox.Show("Blokirani ste", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
				var t = new LogIn();
				t.Show();
				return appointmentRepository.UpdateByID(appointment);
			}
			patientService.UpdatePatient(patientDTO, patientId);
			return appointmentRepository.UpdateByID(appointment);
		}
		
		public Boolean DeleteAppointment(int id, int patientId)
		{
			Patient patient = patientService.ReadPatient(patientId);
			patientDTO = patientService.MakePatientDTO(patientDTO, patient);
			patientDTO.Brojac++;
			if (patient.Brojac > 4)
            {
				patientDTO.Blocked = true;
				patientService.UpdatePatient(patientDTO, patient.Id);
				MessageBox.Show("Blokirani ste", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
				var t = new LogIn();
				t.Show();
				return appointmentRepository.DeleteByID(id);
			}
			patientService.UpdatePatient(patientDTO, patient.Id);
			return appointmentRepository.DeleteByID(id);
		}
		
		public Appointment FindAppointment(int id)
		{
			return appointmentRepository.FindByID(id);
		}

		public List<Appointment> FindAll()
		{
			return appointmentRepository.FindAll();
		}

		public String idFile = @"..\..\..\Data\appointmentID.txt";
		public AppointmentRepository appointmentRepository = new AppointmentRepository();
		public int id = 0;
	}
}
