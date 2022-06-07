/***********************************************************************
 * Module:	DynamicEquipment.cs
 * Author:	Ryzen
 * Purpose: Definition of the Class DynamicEquipment
 ***********************************************************************/

using System;

namespace Model
{
	public class StaticEquipment
	{
		public String Name { get; set; }
		public int Price { get; set; }
		public int Id { get; set; }
		
		public Room room { get; set; }

		public StaticEquipment(string name, int price, int id, Room room)
		{
		  	Name = name;
		  	Price = price;
		  	Id = id;
		  	this.room = room;
		}

		public StaticEquipment()
		{
		}
	 }
}
