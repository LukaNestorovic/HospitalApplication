using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;
using DTO;
using System.IO;

namespace Service
{
    public class DynamicEquipmentService
    {

		public int createId()
        {
			int newID;
			if (File.Exists(idFile))
			{
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}
			else
				newID = 0;
				File.Create(idFile).Close();
			File.WriteAllText(idFile, newID.ToString());
			id = newID;
			return newID;
		}
		public Boolean CreateDynamicalEquipment(DynamicEquipmentDTO dynamicEquipmentDTO)
		{
			int newID = createId();
			String name  = dynamicEquipmentDTO.Name;
			int quantity = dynamicEquipmentDTO.Quantity;
			DateTime dateOfOrder = dynamicEquipmentDTO.DateOfOrder;

			DynamicEquipment dynamicEquipment = new DynamicEquipment(name, quantity,dateOfOrder, newID);
			return dynamicEquipmentRepository.Save(dynamicEquipment);
		}

		public List<DynamicEquipment> ReadAllInStorage()
        {
			return dynamicEquipmentRepository.ReadAllInStorage();
        }

		public int id = 0;
		public DynamicEquipmentRepository dynamicEquipmentRepository = new DynamicEquipmentRepository();
		public String idFile = @"..\..\..\Data\dynamicEquipmentID.txt";
	}
}
