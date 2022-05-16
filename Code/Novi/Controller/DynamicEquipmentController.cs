using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Service;
using DTO;

namespace Controller
{
    public class DynamicEquipmentController
    {
        public DynamicEquipmentService dynamicEquipmentService = new DynamicEquipmentService();

        public Boolean createDynamicEquipment(DynamicEquipmentDTO dynamicEquipmentDTO)
        {
            return dynamicEquipmentService.CreateDynamicalEquipment(dynamicEquipmentDTO);
        }

        public List<DynamicEquipment> ReadAllInStorage()
        {
            return dynamicEquipmentService.ReadAllInStorage();
        }


    }
}
