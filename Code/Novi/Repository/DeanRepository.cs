using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Serialization;

namespace Repository
{
    public class DeanRepository
    {
		public Dean FindByEmail(String email)
		{
			List<Dean> all = serializer.fromJSON(FileName);
			Dean a = null;
			foreach (Dean i in all)
			{
				if (i.Email == email)
				{
					a = i;
					break;
				}
			}
			return a;
		}

		public Dean FindByPassword(String password)
		{
			List<Dean> all = serializer.fromJSON(FileName);
			Dean a = null;
			foreach (Dean i in all)
			{
				if (i.Password == password)
				{
					a = i;
					break;
				}
			}
			return a;
		}

		private static String FileName = @"..\..\..\data\Dean.json";

		private static Serializer<Dean> serializer = new Serializer<Dean>();
	}
}
