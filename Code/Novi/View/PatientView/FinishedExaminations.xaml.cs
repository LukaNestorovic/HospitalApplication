using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for FinishedExaminations.xaml
    /// </summary>
    public partial class FinishedExaminations : Page
    {
        private int id;
        public ObservableCollection<Appointment> appointments;
        public Appointment appointment = new Appointment();
        public AppointmentController appointmentController = new AppointmentController();
        public FinishedExaminations(int id)
        {
            InitializeComponent();
            appointments = new ObservableCollection<Appointment>(appointmentController.FindAllFinished());
            PatientAppointments.ItemsSource = appointments;
            this.id = id;
        }

        private void Rate_Click(object sender, RoutedEventArgs e)
        {
            appointment = (Appointment)PatientAppointments.SelectedItem;
            if (appointment == null)
            {
                MessageBox.Show("Choose appointment", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                var s = new RateAppointment(id, appointment);
                NavigationService.Navigate(s);
                
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new Home(id);
            NavigationService.Navigate(s);
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
        }

        private void Note_Click(object sender, RoutedEventArgs e)
        {
            appointment = (Appointment)PatientAppointments.SelectedItem;
            if (appointment == null)
            {
                MessageBox.Show("Choose appointment", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                var s = new Note(appointment, id);
                NavigationService.Navigate(s);
            }
        }

        private void Prescription_Click(object sender, RoutedEventArgs e)
        {
            var s = new Prescription(id);
            NavigationService.Navigate(s);
        }

        private void Report_Click(object sender, RoutedEventArgs e)
        {
            Appointment appointment1 = new Appointment();
            appointment = (Appointment)PatientAppointments.SelectedItem;
            if (appointment == null)
            {
                MessageBox.Show("Choose appointment", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                appointment1 = appointmentController.FindAppointment(appointment.Id);
                var s = new Report(appointment1, id);
                NavigationService.Navigate(s);
            }
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
