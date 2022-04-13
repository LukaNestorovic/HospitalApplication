/***********************************************************************
 * Module:	Note.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Note
 ***********************************************************************/

using System;

namespace Model
{
	public class Note
	{
		public String Descritpion { get; set; }
		public DateTime BeginAbsence	{ get; set; }
		public DateTime EndAbsence { get; set; }
		public int Id { get; set; }
		
		public Patient patient { get; set; }
		public Doctor doctor { get; set; }

		public Note(string descritpion, DateTime beginAbsence, DateTime endAbsence, int id, Patient patient, Doctor doctor)
		{
		  	Descritpion = descritpion;
		  	BeginAbsence = beginAbsence;
		  	EndAbsence = endAbsence;
		  	Id = id;
		  	this.patient = patient;
		  	this.doctor = doctor;
		}

		public Note()
		{
		}
	 }
}
