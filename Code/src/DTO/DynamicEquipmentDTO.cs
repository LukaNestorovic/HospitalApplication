using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DynamicEquipmentDTO
    {
        public String Name { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfOrder { get; set; }

        public DynamicEquipmentDTO(string name, int quantity, DateTime dateOfOrder)
        {
            Name = name;
            Quantity = quantity;
            DateOfOrder = dateOfOrder;
        }

        public DynamicEquipmentDTO()
        {
        }
    }
}
