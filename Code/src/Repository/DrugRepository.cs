using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Serialization;

namespace Repository
{
    public class DrugRepository
    {
		public List<Drug> FindAll()
		{
			return serializer.fromJSON(FileName);
		}

		public Drug FindByID(int id)
		{
			List<Drug> all = serializer.fromJSON(FileName);
			Drug a = null;
			foreach (Drug i in all)
			{
				if (i.Id == id)
				{
					a = i;
					break;
				}
			}
			return a;
		}

		public Boolean Save(Drug drug)
		{
			List<Drug> all = serializer.fromJSON(FileName);
			all.Add(drug);
			serializer.toJSON(FileName, all);
			return true;
		}

		public Boolean DeleteByID(int id)
		{
			List<Drug> all = serializer.fromJSON(FileName);
			foreach (Drug i in all)
			{
				if (i.Id == id)
				{
					all.Remove(i);
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return true;
		}

		public Boolean UpdateByID(Drug drug)
		{
			List<Drug> all = serializer.fromJSON(FileName);
			for (int i = 0; i < all.Count; i++)
			{
				if (all[i].Id == drug.Id)
				{
					all[i] = drug;
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return false;
		}

		private static String FileName = @"..\..\..\Data\Drugs.json";

		private static Serializer<Drug> serializer = new Serializer<Drug>();
	}
}
