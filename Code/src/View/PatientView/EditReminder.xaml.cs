using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Controller;
using Model;
using DTO;

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for EditReminder.xaml
    /// </summary>
    public partial class EditReminder : Page
    {
        private int id;
        public Model.Reminder reminder = new Model.Reminder();
        public ReminderDTO reminderDTO = new ReminderDTO();
        public ReminderController reminderController = new ReminderController();
        public EditReminder(Model.Reminder reminder, int id)
        {
            InitializeComponent();
            DP.SelectedDate = reminder.DateTime;
            TBReminder.Text = reminder.Event;
            this.reminder = reminder;
            this.id = id;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var s = new Reminder(id);
            NavigationService.Navigate(s);
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            reminderDTO.Event = TBReminder.Text;
            reminderDTO.DateTime = DP.SelectedDate.GetValueOrDefault();
            reminderDTO.Patient = reminder.Patient;
            reminderController.UpdateReminder(reminderDTO, reminder.Id);
            var s = new Reminder(id);
            NavigationService.Navigate(s);
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            String naslov = (String)LNaslov.Content;
            var s = new ProjekatSIMS.Help(naslov);
            s.Show();
        }
    }
}
