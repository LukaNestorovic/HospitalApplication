/***********************************************************************
 * Module:	Room.cs
 * Author:	Ryzen
 * Purpose: Definition of the Class Room
 ***********************************************************************/

using System;

namespace Model
{
	public class Room
	{
		public String RoomType { get; set; }
		public String Name { get; set; }
		public int Id { get; set; }

		public Room(string roomType, string name, int id)
		{
			RoomType = roomType;
			Name = name;
			Id = id;
		}

		public Room()
		{
		}
	 }
}
