/***********************************************************************
 * Module:	Instructions.cs
 * Author:	Ryzen
 * Purpose: Definition of the Class Instructions
 ***********************************************************************/

using System;
using Appointments.Model;

namespace Model
{
	public class Instructions
	{
		public String ForWho { get; set; }
		public String Description { get; set; }
		
		public Appointments.Model.Appointment appointment { get; set; }
		public Doctor doctor  { get; set; }

		public Instructions(string forWho, string description, Appointments.Model.Appointment appointment, Doctor doctor)
		{
		  	ForWho = forWho;
		  	Description = description;
		  	this.appointment = appointment;
		  	this.doctor = doctor;
		}

		public Instructions()
		{
		}
	 }
}
