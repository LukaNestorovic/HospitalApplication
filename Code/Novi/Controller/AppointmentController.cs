/***********************************************************************
 * Module:	AppointmentController.cs
 * Author:	SN CAR CODING
 * Purpose: Definition of the Class Controller.AppointmentController
 ***********************************************************************/

using System;
using Service;
using Model;
using System.Collections.Generic;
using DTO;

namespace Controller
{
	public class AppointmentController
	{
		public PatientService patientService = new PatientService();
		public RoomService roomService = new RoomService();
		public DoctorService doctorService = new DoctorService();
		public Boolean CreateAppointment(AppointmentDTO appointmentDTO)
		{
			return appointmentService.CreateAppointment(appointmentDTO);
		}
		
		public Boolean DeleteAppointment(int id, int patientId)
		{
			return appointmentService.DeleteAppointment(id, patientId);
		}
		
		public Boolean UpdateAppointment(AppointmentDTO appointmentDTO, int id)
		{
			return appointmentService.UpdateAppointment(appointmentDTO, id);
		}
		
		public Appointment ReadAppointment(int id)
		{
			Appointment appointment = appointmentService.ReadAppointment(id);
			return appointment;
		}

		public Appointment ReadWithPriority(DateTime date)
        {
			Appointment appointment = appointmentService.ReadWithPriority(date);
			return appointment;
        }

		public Appointment ReadWithPriorityDoctor(int id, DateTime date)
        {
			Appointment appointment = appointmentService.ReadWithPriorityDoctor(id, date);
			return appointment;
        }

		public List<Appointment> ReadAll()
		{
			List<Appointment> appointments = appointmentService.ReadAll();
			return appointments;
		}

		public List<Appointment> ReadAllByPatientId(int id)
        {
			List<Appointment> appointments = appointmentService.ReadAllByPatientId(id);
			return appointments;
        }

		public List<Appointment> ReadAllByDoctorId(int id)
		{
			List<Appointment> appointments = appointmentService.ReadAllByDoctorId(id);
			return appointments;
		}

		public List<Appointment> ReadAllWithoutPatient()
		{
			List<Appointment> appointments = appointmentService.ReadAllWithoutPatient();
			return appointments;
		}

		public List<Appointment> ReadByDoctor(int doctorId)
        {
			Doctor doctor = doctorService.ReadDoctor(doctorId);
			return appointmentService.ReadByDoctor(doctor);
        }

		public List<Appointment> ReadIfFinished()
        {
			return appointmentService.ReadIfFinished();
        }

		public AppointmentService appointmentService = new AppointmentService();
	
	}
}
