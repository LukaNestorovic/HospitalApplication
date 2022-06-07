/***********************************************************************
 * Module:	Appointment.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Appointment
 ***********************************************************************/

using System;
using Model;

namespace Appointments.Model
{
	public class Appointment
	{
		public DateTime DateTime { get; set; }
		public String Descripton { get; set; }
		public int Duration { get; set; }
		public Boolean Emergency { get; set; }
		public int Id { get; set; }
		public String Anamnesis { get; set; }
		public Boolean Finished { get; set; }
		public Patient Patient { get; set; }
		public Doctor Doctor { get; set; }
		public Room Room { get; set; }
		public String Comment { get; set; }
		  public Appointment(DateTime dateTime, string descripton, int duration, bool emergency, int id,  Patient patient, Doctor doctor, Room room, Boolean finished, string anamnesis, string comment)
		  {
				DateTime = dateTime;
				Descripton = descripton;
				Duration = duration;
				Emergency = emergency;
				Id = id;
			    Finished = finished;
				this.Patient = patient;
				this.Doctor = doctor;
				this.Room = room;
				Anamnesis = anamnesis;
				Comment = comment;
		  }

		  public Appointment()
		  {
		  }
	 }
}
