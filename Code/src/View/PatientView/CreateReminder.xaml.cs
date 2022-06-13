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
using Appointments.Controller;

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for CreateReminder.xaml
    /// </summary>
    public partial class CreateReminder : Page
    {
        public int id;
        public ReminderDTO reminderDTO = new ReminderDTO();
        public ReminderController reminderController = new ReminderController();
        public PatientController patientController = new PatientController();
        public CreateReminder(int id)
        {
            InitializeComponent();
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
            reminderDTO.Patient = patientController.FindPatientById(id);
            reminderDTO.Event = TBReminder.Text;
            reminderDTO.DateTime = DP.SelectedDate.GetValueOrDefault();
            reminderController.CreateReminder(reminderDTO);
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
