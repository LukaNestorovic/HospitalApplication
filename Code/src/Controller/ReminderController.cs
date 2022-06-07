using System;

using Service;
using Model;
using System.Collections.Generic;
using DTO;

namespace Controller
{
    public class ReminderController
    {
        public ReminderService reminderService = new ReminderService();
        public Boolean CreateReminder(ReminderDTO reminderDTO)
        {
            return reminderService.CreateReminder(reminderDTO);
        }

        public Boolean UpdateReminder(ReminderDTO reminderDTO, int id)
        {
            return reminderService.UpdateReminder(reminderDTO, id);
        }

        public Reminder FindReminderById(int id)
        {
            return reminderService.FindReminderById(id);
        }

        public Boolean DeleteReminder(int id)
        {
            return reminderService.DeleteReminder(id);
        }

        public List<Reminder> FindAll()
        {
            return reminderService.FindAll();
        }

        public Boolean Notification()
        {
            return reminderService.Notification();
        }
    }
}
