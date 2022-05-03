/***********************************************************************
 * Module:	MedicalRecord.cs
 * Author:	lukaa
 * Purpose: Definition of the Class MedicalRecord
 ***********************************************************************/

using System;

namespace Model
{
	public class MedicalRecord
	{
		public String Allergies { get; set; }
		
		public Patient patient { get; set; }

		public int Id { get; set; }

		public MedicalRecord(String allergies, Patient patient, int id)
		{
		  	Allergies = allergies;
		  	this.patient = patient;
			Id = id;
		}

		public MedicalRecord()
		{
		}
	 }
}
