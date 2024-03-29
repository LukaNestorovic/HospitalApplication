/***********************************************************************
 * Module:	MedicalRecord.cs
 * Author:	lukaa
 * Purpose: Definition of the Class MedicalRecord
 ***********************************************************************/

using System;
using Appointments.Model;

namespace Model
{
	public class MedicalRecord
	{

        public String Allergies { get; set; }
		
		public Patient patient { get; set; }

		public int Id { get; set; }

        public String Anamnesis { get; set; }

		
		public MedicalRecord (Patient patient, int id, String anamnesis, String allergies)
        {
			this.patient=patient;
			Id = id;
			Anamnesis = anamnesis;
        }
		public MedicalRecord()
		{
		}
	 }
}
