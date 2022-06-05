using System;
using Model;
using Repository;
using System.IO;
using System.Collections.Generic;
using Serialization;
using DTO;
using System.Windows;


namespace Service
{
    public class ReminderService
    {
		public ReminderRepository reminderRepository = new ReminderRepository();
		public String idFile = @"..\..\..\Data\reminderID.txt";
		public int id = 0;
		
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

		public Boolean CreateReminder(ReminderDTO reminderDTO)
        {
			int newId = createId();
			Reminder reminder = new Reminder(reminderDTO.DateTime, reminderDTO.Event, newId,reminderDTO.Patient);
			return reminderRepository.Save(reminder);
        }

		public Boolean UpdateReminder(ReminderDTO reminderDTO, int id)
        {
			Reminder reminder = reminderRepository.FindByID(id);
			reminder.DateTime = reminderDTO.DateTime;
			reminder.Event = reminderDTO.Event;
			reminder.Patient = reminderDTO.Patient;
			return reminderRepository.UpdateByID(reminder);
        }

		public Boolean DeleteReminder(int id)
        {
			return reminderRepository.DeleteByID(id);
        }

		public Reminder FindReminder(int id)
        {
			return reminderRepository.FindByID(id);
        }

		public List<Reminder> FindAll()
        {
			return reminderRepository.FindAll();
        }

		public Boolean Notification()
        {
			List<Reminder> reminders = FindAll();
			foreach(Reminder r in reminders)
            {
				TimeSpan razlika = r.DateTime - DateTime.Now;
				if(razlika.TotalMinutes < 15 && razlika.TotalMinutes > 0)
                {
					MessageBox.Show("Za " + (int)razlika.TotalMinutes + " minuta treba da " + r.Event, "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
				}
            }
			return true;
        }
	}
}
