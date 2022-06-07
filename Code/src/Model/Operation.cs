/***********************************************************************
 * Module:	Operation.cs
 * Author:	Ryzen
 * Purpose: Definition of the Class Operation
 ***********************************************************************/

using System;
using System.Collections;
using Appointments.Model;

namespace Model
{
	public class Operation
	{
		public DateTime DateTime { get; set; }
		public int Duration { get; set; }
		public String Type { get; set; }
		public int Id { get; set; }
		public Doctor doctor { get; set; }
		public Patient patient { get; set; }
		public Room room { get; set; }

		public Operation(DateTime dateTime, int duration, String type, int id, Patient patient, Doctor doctor, Room room)
		{
		  	DateTime = dateTime;
		  	Duration = duration;
		  	Type = type;
		  	Id = id;
		  	this.patient = patient;
		  	this.doctor = doctor;
		  	this.room = room;
		}

		public Operation()
		{
		}
	 }
}
