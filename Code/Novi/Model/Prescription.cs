/***********************************************************************
 * Module:	Prescription.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Prescription
 ***********************************************************************/

using System;
using System.Collections;

namespace Model
{
	public class Prescription
	{
		public String Instructions { get; set; }
		public int Id { get; set; }
		
		public Doctor doctor { get; set; }
		public Patient patient { get; set; }
		public System.Collections.ArrayList drug;
		

		public Prescription(string instructions, int id, Doctor doctor, Patient patient, ArrayList drug)
		{
		  	Instructions = instructions;
		  	Id = id;
		  	this.doctor = doctor;
		  	this.patient = patient;
		  	this.drug = drug;
		}

		public Prescription()
		{
		}
	 }
}
