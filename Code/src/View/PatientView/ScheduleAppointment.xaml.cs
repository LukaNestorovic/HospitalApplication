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
using DTO;
using Appointments.Model;
using Appointments.Controller;
using Appointments.DTO;
using Appointments.Service;

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for ScheduleAppointment.xaml
    /// </summary>
    public partial class ScheduleAppointment : Page
    {
        private int id;
        public ObservableCollection<Appointment> appointments;
        public Appointment appointment = new Appointment();
        public AppointmentController appointmentController = new AppointmentController();
        public AppointmentDTO appointmentDTO = new AppointmentDTO();
        public PatientController patientController = new PatientController();
        public Patient patient = new Patient();
        public AppointmentFindService appointmentFindService = new AppointmentFindService();
        public ScheduleAppointment(int id, DateTime start, DateTime end)
        {
            InitializeComponent();
            DateTime dt = new DateTime();
            if (start == dt || end == dt)
            {
                appointments = new ObservableCollection<Appointment>(appointmentController.FindAllWithoutPatient());
                PatientAppointments.ItemsSource = appointments;
            }
            else
            {
                appointments = new ObservableCollection<Appointment>(appointmentFindService.Filter(start, end));
                PatientAppointments.ItemsSource = appointments;
            }
            this.id = id;
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new ScheduledAppointments(id);
            NavigationService.Navigate(s);
        }

        private void Schedule_Click(object sender, RoutedEventArgs e)
        {
            appointment = (Appointment)PatientAppointments.SelectedItem;
            if (appointment == null)
            {
                MessageBox.Show("Choose appointment", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                patient = patientController.FindPatientById(id);
                appointmentDTO.DateTime = appointment.DateTime;
                appointmentDTO.Descripton = appointment.Descripton;
                appointmentDTO.Duration = appointment.Duration;
                appointmentDTO.Emergency = appointment.Emergency;
                appointmentDTO.Doctor = appointment.Doctor;
                appointmentDTO.Room = appointment.Room;
                appointmentDTO.Patient = patient;
                appointmentDTO.Finished = false;
                appointmentController.UpdateAppointment(appointmentDTO, appointment.Id);
                var s = new ScheduledAppointments(id);
                NavigationService.Navigate(s);            
            }
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();

        }
        private void Help_Click(object sender, RoutedEventArgs e)
        {
            String naslov = (String)LNaslov.Content;
            var s = new ProjekatSIMS.Help(naslov);
            s.Show();
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            DateTime start = DP.SelectedDate.GetValueOrDefault();
            DateTime end = DP1.SelectedDate.GetValueOrDefault();
            if (end > start)
            {
                var s = new ScheduleAppointment(id, start, end);
                NavigationService.Navigate(s);
            }
            else
            {
                MessageBox.Show("Izaberite krajnji datum nakon pocetnog", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
