using System;
using Model;
using Repository;
using System.IO;
using System.Collections.Generic;

namespace Service
{
    public class DrugService
    {
		public Boolean CreateDrug(String name, String ingredients, Boolean approved, int drugnum)
		{
			int newID;
			if (File.Exists(idFile))
			{
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}
			else
				newID = 0;
			Drug newDrug = new Drug(name, ingredients, approved, newID, drugnum);

			File.WriteAllText(idFile, newID.ToString());

			return drugRepository.Save(newDrug);
		}

		public Boolean UpdateDrug(String name, String ingredients, Boolean approved, int drugnum, int id)
		{
			Drug drug = drugRepository.FindByID(id);
			drug.Name = name;
			drug.Ingredients = ingredients;
			drug.Approved = approved;
			drug.Drugnum = drugnum;
			return drugRepository.UpdateByID(drug);
		}

		public Boolean DeleteDrug(int id)
		{
			return drugRepository.DeleteByID(id);
		}

		public Drug ReadDrug(int id)
		{
			return drugRepository.FindByID(id);
		}

		public List<Drug> ReadAll()
		{
			return drugRepository.FindAll();
		}

		public DrugRepository drugRepository = new DrugRepository();
		public String idFile = @"..\..\..\Data\drugID.txt";
	}
}
