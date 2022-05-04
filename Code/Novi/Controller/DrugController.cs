using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Model;

namespace Controller
{
    public class DrugController
    {
		public Boolean CreateDrug(String name, String ingredients, Boolean approved, int drugnum)
		{
			return drugService.CreateDrug(name, ingredients, approved, drugnum);
		}

		public Boolean DeleteDrug(int id)
		{
			return drugService.DeleteDrug(id);
		}

		public Drug ReadDrug(int id)
		{
			Drug drug = drugService.ReadDrug(id);
			return drug;
		}

		public List<Drug> ReadAll()
		{
			List<Drug> drugs = drugService.ReadAll();
			return drugs;
		}
		public Boolean UpdateDrug(String name, String ingredients, Boolean approved, int drugnum, int id)
		{
			return drugService.UpdateDrug(name, ingredients, approved, drugnum, id);
		}

		public DrugService drugService = new DrugService();
	}
}
