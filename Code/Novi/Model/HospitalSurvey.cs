/***********************************************************************
 * Module:	HospitalSurvey.cs
 * Author:	SN CAR CODING
 * Purpose: Definition of the Class Model.HospitalSurvey
 ***********************************************************************/

using System;
using Appointments.Model;

namespace Model
{
	public class HospitalSurvey
	{
		public int Question1 { get; set; }
		public int Id { get; set; }
		public int Question2 { get; set; }
		public int Question3 { get; set; }
		
		public Patient patient { get; set; }

		public HospitalSurvey(int question1,int question2, int question3,int id, Patient patient)
		{ 
		  	Id = id;
		  	this.patient = patient;
			Question1 = question1;
			Question2 = question2;
			Question3 = question3;
		}

		public HospitalSurvey()
		{
		}
	 }
}
