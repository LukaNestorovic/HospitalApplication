using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Serialization;
using Interface;

namespace Repository
{
    public class ReminderRepository : IReminderRepository
    {
		public List<Reminder> FindAll()
		{
			return serializer.fromJSON(FileName);
		}

		public Reminder FindByID(int id)
		{
			List<Reminder> all = serializer.fromJSON(FileName);
			Reminder a = null;
			foreach (Reminder i in all)
			{
				if (i.Id == id)
				{
					a = i;
					break;
				}
			}
			return a;
		}

		public Boolean Save(Reminder reminder)
		{
			List<Reminder> all = serializer.fromJSON(FileName);
			all.Add(reminder);
			serializer.toJSON(FileName, all);
			return true;
		}

		public Boolean DeleteByID(int id)
		{
			List<Reminder> all = serializer.fromJSON(FileName);
			foreach (Reminder i in all)
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

		public Boolean UpdateByID(Reminder reminder)
		{
			List<Reminder> all = serializer.fromJSON(FileName);
			for (int i = 0; i < all.Count; i++)
			{
				if (all[i].Id == reminder.Id)
				{
					all[i] = reminder;
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return false;
		}

		private static String FileName = @"..\..\..\data\Reminders.json";

		private static Serializer<Reminder> serializer = new Serializer<Reminder>();
	}
}
