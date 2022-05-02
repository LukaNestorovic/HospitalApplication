/***********************************************************************
 * Module:	Appointment.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Appointment
 ***********************************************************************/

using System;

namespace Model
{
	public class Appointment
	{
		public DateTime DateTime { get; set; }
		public String Descripton { get; set; }
		public int Duration { get; set; }
		public Boolean Emergency { get; set; }
		public int Id { get; set; }
		
		public Patient Patient { get; set; }
		public Doctor Doctor { get; set; }
		public Room Room { get; set; }

		  public Appointment(DateTime dateTime, string descripton, int duration, bool emergency, int id, Patient patient, Doctor doctor, Room room)
		  {
				DateTime = dateTime;
				Descripton = descripton;
				Duration = duration;
				Emergency = emergency;
				Id = id;
				this.Patient = patient;
				this.Doctor = doctor;
				this.Room = room;
		  }

		  public Appointment()
		  {
		  }
	 }
}
