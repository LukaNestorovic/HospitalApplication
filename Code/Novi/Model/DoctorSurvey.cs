/***********************************************************************
 * Module:	Survey.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Survey
 ***********************************************************************/

using System;
using Appointments.Model;

namespace Model
{
	public class DoctorSurvey
	{
		public int Question1 { get; set; }
		public int Id { get; set; }
		public int Question2 { get; set; }
		public int Question3 { get; set; }

		public Patient patient { get; set; }
		public Doctor doctor { get; set; }

		public DoctorSurvey(int id, int question1, int question2, int question3, Patient patient, Doctor doctor)
		{
		  	Id = id;
			Question1 = question1;
			Question2 = question2;
			Question3 = question3;
			this.patient = patient;
		  	this.doctor = doctor;
		}

		public DoctorSurvey()
		{
		}
	 }
}
