using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Serialization;

namespace Repository
{
    public class SecretaryRepository
    {
		public Secretary FindByEmail(String email)
		{
			List<Secretary> all = serializer.fromJSON(FileName);
			Secretary a = null;
			foreach (Secretary i in all)
			{
				if (i.Email == email)
				{
					a = i;
					break;
				}
			}
			return a;
		}

		private static String FileName = @"..\..\..\data\Secretary.json";

		private static Serializer<Secretary> serializer = new Serializer<Secretary>();
	}
}
