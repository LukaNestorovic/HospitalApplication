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

		public Boolean UpdateAppointmentAntiTroll(AppointmentDTO appointmentDTO, int id)
		{
			return appointmentService.UpdateAppointmentAntiTroll(appointmentDTO, id);
		}

		public Appointment FindAppointment(int id)
		{
			Appointment appointment = appointmentService.FindAppointment(id);
			return appointment;
		}

		public Appointment FindWithDatePriority(DateTime date)
        {
			Appointment appointment = appointmentFindService.FindWithDatePriority(date);
			return appointment;
        }

		public Appointment FindWithDoctorPriority(int id, DateTime date)
        {
			Appointment appointment = appointmentFindService.FindWithDoctorPriority(id, date);
			return appointment;
        }

		public List<Appointment> FindAll()
		{
			List<Appointment> appointments = appointmentService.FindAll();
			return appointments;
		}

		public List<Appointment> FindAllByPatientId(int id)
        {
			List<Appointment> appointments = appointmentFindService.FindAllByPatientId(id);
			return appointments;
        }

		public List<Appointment> FindAllByDoctorId(int id)
		{
			List<Appointment> appointments = appointmentFindService.FindAllByDoctorId(id);
			return appointments;
		}

		public List<Appointment> FindAllWithoutPatient()
		{
			List<Appointment> appointments = appointmentFindService.FindAllWithoutPatient();
			return appointments;
		}

		public List<Appointment> FindAllFinished()
        {
			return appointmentFindService.FindAllFinished();
        }

		public AppointmentService appointmentService = new AppointmentService();
		public AppointmentFindService appointmentFindService = new AppointmentFindService();
	
	}
}
