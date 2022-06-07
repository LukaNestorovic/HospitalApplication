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
        public ScheduleAppointment(int id)
        {
            InitializeComponent();
            appointments = new ObservableCollection<Appointment>(appointmentController.FindAllWithoutPatient());
            PatientAppointments.ItemsSource = appointments;
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
            var s = new Help(id);
            NavigationService.Navigate(s);
        }
    }
}
