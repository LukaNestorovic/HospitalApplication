/***********************************************************************
 * Module:	Laboratory.cs
 * Author:	SN CAR CODING
 * Purpose: Definition of the Class Model.Laboratory
 ***********************************************************************/

using System;

namespace Model
{
	public class Laboratory
	{
		public Doctor doctor { get; set; }
		public Patient patient { get; set; }
	
		private String Description { get; set; }

		public Laboratory(Doctor doctor, Patient patient, string description)
		{
		  	this.doctor = doctor;
		  	this.patient = patient;
		  	Description = description;
		}

		public Laboratory()
		{
		}
	 }
}
