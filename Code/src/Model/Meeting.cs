/***********************************************************************
 * Module:	Meeting.cs
 * Author:	Ryzen
 * Purpose: Definition of the Class Meeting
 ***********************************************************************/

using System;
using System.Collections;

namespace Model
{
	public class Meeting
	{
		public DateTime DateTime { get; set; }
		public int Duration { get; set; }
		public String Description { get; set; }
		public int Id { get; set; }
		
		public System.Collections.ArrayList doctor;

		public Secretary secretary { get; set; }
		public Room room { get; set; }

		public Meeting(DateTime dateTime, int duration, string description, int id, ArrayList doctor, Secretary secretary, Room room)
		{
			 DateTime = dateTime;
			 Duration = duration;
			 Description = description;
			 Id = id;
			 this.doctor = doctor;
			 this.secretary = secretary;
			 this.room = room;
		}

		public Meeting()
		{
		}
	 }
}
