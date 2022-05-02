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
		
		public Appointment ReadApp(int id)
		{
			Appointment appointment = appointmentService.ReadApp(id);
			return appointment;
		}

		public Appointment ReadWithPriority(DateTime date)
        {
			Appointment appointment = appointmentService.ReadWithPriority(date);
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

		public List<Appointment> ReadAllWithoutPatient()
		{
			List<Appointment> appointments = appointmentService.ReadAllWithoutPatient();
			return appointments;
		}

		public AppointmentService appointmentService = new AppointmentService();
	
	}
}
