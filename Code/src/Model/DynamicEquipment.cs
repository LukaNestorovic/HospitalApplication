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
		public DateTime DateOfOrder { get; set; }
		public int Id { get; set; }



        public DynamicEquipment(string name, int quantity, DateTime dateOfOrder, int id)
        {
            Name = name;
            Quantity = quantity;
            DateOfOrder = dateOfOrder;
            Id = id;
        }

       

        public DynamicEquipment()
		{
		}
	 }
}
