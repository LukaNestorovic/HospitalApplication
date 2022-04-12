/***********************************************************************
 * Module:	Operation.cs
 * Author:	Ryzen
 * Purpose: Definition of the Class Operation
 ***********************************************************************/

using System;
using System.Collections;

namespace Model
{
	public class Operation
	{
		public DateTime DateTime { get; set; }
		public int Duration { get; set; }
		public String Type { get; set; }
		public int Id { get; set; }
		
		public Patient patient { get; set; }
		public System.Collections.ArrayList doctor;
		
		/// <pdGenerated>default getter</pdGenerated>
		public System.Collections.ArrayList GetDoctor()
		{
			if (doctor == null)
				doctor = new System.Collections.ArrayList();
			return doctor;
		}
		
		/// <pdGenerated>default setter</pdGenerated>
		public void SetDoctor(System.Collections.ArrayList newDoctor)
		{
			RemoveAllDoctor();
			foreach (Doctor oDoctor in newDoctor)
				AddDoctor(oDoctor);
		}
		
		/// <pdGenerated>default Add</pdGenerated>
		public void AddDoctor(Doctor newDoctor)
		{
			if (newDoctor == null)
				return;
			if (this.doctor == null)
				this.doctor = new System.Collections.ArrayList();
			if (!this.doctor.Contains(newDoctor))
				this.doctor.Add(newDoctor);
		}
		
		/// <pdGenerated>default Remove</pdGenerated>
		public void RemoveDoctor(Doctor oldDoctor)
		{
			if (oldDoctor == null)
				return;
			if (this.doctor != null)
				if (this.doctor.Contains(oldDoctor))
					this.doctor.Remove(oldDoctor);
		}
		
		/// <pdGenerated>default removeAll</pdGenerated>
		public void RemoveAllDoctor()
		{
			if (doctor != null)
				doctor.Clear();
		}
		public Room room { get; set; }

		  public Operation(DateTime dateTime, int duration, String type, int id, Patient patient, ArrayList doctor, Room room)
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
