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
using System.Windows.Shapes;
using Model;
using Controller;

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        private int id;
        public Patient patient = new Patient();
        public PatientController patientController = new PatientController();
        public int brojac = 0;
    public Home(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Appointments_Click(object sender, RoutedEventArgs e)
        {
            var s = new ScheduledAppointments(id);
            NavigationService.Navigate(s);
        }

        private void Medicine_Click(object sender, RoutedEventArgs e)
        {
            var s = new Prescription(id);
            NavigationService.Navigate(s);
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
        }

        private void Schedule_Click(object sender, RoutedEventArgs e)
        {
            var s = new ScheduleWithPriority(id);
            NavigationService.Navigate(s);
        }

        private void MedicalRecord_Click(object sender, RoutedEventArgs e)
        {
            var s = new MedicalRecord(id);
            NavigationService.Navigate(s);
        }

        private void Reminder_Click(object sender, RoutedEventArgs e)
        {
            var s = new Reminder(id);
            NavigationService.Navigate(s);
        }

        private void Rate_Click(object sender, RoutedEventArgs e)
        {
            var s = new RateHospital(id);
            NavigationService.Navigate(s);
        }

        private void Finished_Click(object sender, RoutedEventArgs e)
        {
            var s = new FinishedExaminations(id);
            NavigationService.Navigate(s);
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            var s = new Help(id);
            NavigationService.Navigate(s);
        }

    }
}
