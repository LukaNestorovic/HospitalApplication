/***********************************************************************
 * Module:	StaticEquipment.cs
 * Author:	Ryzen
 * Purpose: Definition of the Class StaticEquipment
 ***********************************************************************/

using System;

namespace Model
{
	public class DynamicEquipment
	{
		public String Name { get; set; }
		public int Quantity { get; set; }
		public int Price { get; set; }
		public int Id { get; set; }

		public DynamicEquipment(string name, int quantity, int price, int id)
		{
		  	Name = name;
		  	Quantity = quantity;
		  	Price = price;
		  	Id = id;
		}

		public DynamicEquipment()
		{
		}
	 }
}
