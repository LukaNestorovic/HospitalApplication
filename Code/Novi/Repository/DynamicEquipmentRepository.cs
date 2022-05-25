using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Serialization;

namespace Repository
{
    public class DynamicEquipmentRepository
    {
		public Boolean Save(DynamicEquipment dynamicEquipment)
		{
			List<DynamicEquipment> all = serializer.fromJSON(FileName);
			all.Add(dynamicEquipment);
			serializer.toJSON(FileName, all);
			return true;
		}

		public Boolean UpdateByID(DynamicEquipment dynamicEquipment)
		{
			List<DynamicEquipment> all = serializer.fromJSON(FileName);
			for (int i = 0; i < all.Count; i++)
			{
				if (all[i].Id == dynamicEquipment.Id)
				{
					all[i] = dynamicEquipment;
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return false;
		}

		public DynamicEquipment FindByID(int id)
		{
			List<DynamicEquipment> all = serializer.fromJSON(FileName);
			DynamicEquipment a = null;
			foreach (DynamicEquipment i in all)
			{
				if (i.Id == id)
				{
					a = i;
					break;
				}
			}
			return a;
		}

		public List<DynamicEquipment> FindAll()
		{
			return serializer.fromJSON(FileName);
		}
		public List<DynamicEquipment> ReadAllInStorage()
		{
			List<DynamicEquipment> all = serializer.fromJSON(FileName);
			List<DynamicEquipment> ret = new List<DynamicEquipment>();
			foreach (DynamicEquipment i in all)
			{
				if (i.DateOfOrder.AddDays(3) <= DateTime.Now)
				{
					ret.Add(i);
				}
			}
			return ret;
		}

		private static String FileName = @"..\..\..\data\DynamicEquipment.json";

		private static Serializer<DynamicEquipment> serializer = new Serializer<DynamicEquipment>();
	}
}
