/***********************************************************************
 * Module:	AppointmentController.cs
 * Author:	SN CAR CODING
 * Purpose: Definition of the Class Controller.AppointmentController
 ***********************************************************************/

using System;
using Service;
using Model;
using System.Collections.Generic;

namespace Controller
{
	public class AppointmentController
	{
		public PatientService patientService = new PatientService();
		public RoomService roomService = new RoomService();
		public DoctorService doctorService = new DoctorService();
		public Boolean CreateApp(DateTime dateTime, String description, int duration, Boolean emergency, int patientId, int doctorId, int roomId)
		{
			Patient patient = patientService.ReadPatient(patientId);
			Doctor doctor = doctorService.ReadDoctor(doctorId);
			Room room = roomService.ReadRoom(roomId);
			return appointmentService.CreateApp(dateTime, description, duration, emergency, patient, doctor, room);
		}
		
		public Boolean DeleteApp(int id)
		{
			return appointmentService.DeleteApp(id);
		}
		
		public Boolean UpdateApp(DateTime dateTime, String description, int duration, Boolean emergency, int patientId, int doctorId, int roomId, int appId)
		{
			Patient patient = patientService.ReadPatient(patientId);
			Doctor doctor = doctorService.ReadDoctor(doctorId);
			Room room = roomService.ReadRoom(roomId);
			return appointmentService.UpdateApp(dateTime, description, duration, emergency, patient, doctor, room, appId);
		}
		
		public String[] ReadApp(int id)
		{
			Appointment appointment = appointmentService.ReadApp(id);
//			String[] appointmentDTO = new String[8];
//			appointmentDTO[0] = appointment.DateTime.ToString();
//			appointmentDTO[1] = appointment.Descripton;
//			appointmentDTO[2] = appointment.Duration.ToString();
//			appointmentDTO[3] = appointment.Emergency.ToString();
//			appointmentDTO[4] = appointment.patient.Id.ToString();
//			appointmentDTO[5] = appointment.doctor.Id.ToString();
//			appointmentDTO[6] = appointment.room.Id.ToString();
//			appointmentDTO[7] = appointment.Id.ToString();
			return appointment;
		}

		public List<String[]> ReadAll()
		{
			List<Appointment> appointments = appointmentService.ReadAll();
//			List<String[]> appointmentDTOs = new List<String[]>();
//			foreach (Appointment appointment in appointments)
//			{
//				String[] appointmentDTO = new String[8];
//				appointmentDTO[0] = appointment.DateTime.ToString();
//				appointmentDTO[1] = appointment.Descripton;
//				appointmentDTO[2] = appointment.Duration.ToString();
//				appointmentDTO[3] = appointment.Emergency.ToString();
//				appointmentDTO[4] = appointment.patient.Id.ToString();
//				appointmentDTO[5] = appointment.doctor.Id.ToString();
//				appointmentDTO[6] = appointment.room.Id.ToString();
//				appointmentDTO[7] = appointment.Id.ToString();
//			}
			return appointments;
		}

		public AppointmentService appointmentService = new AppointmentService();
	
	}
}
