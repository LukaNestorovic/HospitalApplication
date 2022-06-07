/***********************************************************************
 * Module:	AppointmentController.cs
 * Author:	SN CAR CODING
 * Purpose: Definition of the Class Controller.AppointmentController
 ***********************************************************************/

using System;
using Service;
using Appointments.Service;
using Appointments.Model;
using System.Collections.Generic;
using Appointments.DTO;

namespace Appointments.Controller
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

		public Boolean UpdateAppointmentAntiTroll(AppointmentDTO appointmentDTO, int id)
		{
			return appointmentService.UpdateAppointmentAntiTroll(appointmentDTO, id);
		}

		public Appointments.Model.Appointment FindAppointment(int id)
		{
			Appointments.Model.Appointment appointment = appointmentService.FindAppointment(id);
			return appointment;
		}

		public Appointments.Model.Appointment FindWithDatePriority(DateTime date)
        {
			Appointments.Model.Appointment appointment = appointmentFindService.FindWithDatePriority(date);
			return appointment;
        }

		public Appointments.Model.Appointment FindWithDoctorPriority(int id, DateTime date)
        {
			Appointments.Model.Appointment appointment = appointmentFindService.FindWithDoctorPriority(id, date);
			return appointment;
        }

		public List<Appointments.Model.Appointment> FindAll()
		{
			List<Appointments.Model.Appointment> appointments = appointmentService.FindAll();
			return appointments;
		}

		public List<Appointments.Model.Appointment> FindAllByPatientId(int id)
        {
			List<Appointments.Model.Appointment> appointments = appointmentFindService.FindAllByPatientId(id);
			return appointments;
        }

		public List<Appointments.Model.Appointment> FindAllByDoctorId(int id)
		{
			List<Appointments.Model.Appointment> appointments = appointmentFindService.FindAllByDoctorId(id);
			return appointments;
		}

		public List<Appointments.Model.Appointment> FindAllWithoutPatient()
		{
			List<Appointments.Model.Appointment> appointments = appointmentFindService.FindAllWithoutPatient();
			return appointments;
		}

		public List<Appointments.Model.Appointment> FindAllFinished()
        {
			return appointmentFindService.FindAllFinished();
        }

		public AppointmentService appointmentService = new AppointmentService();
		public AppointmentFindService appointmentFindService = new AppointmentFindService();
	
	}
}
