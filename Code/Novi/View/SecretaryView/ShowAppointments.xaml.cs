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
using System.Collections.ObjectModel;
using Controller;
using Model;

namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for ShowAppointments.xaml
    /// </summary>
    public partial class ShowAppointments : Window
    {
        public ObservableCollection<Appointment> appointments;
        public AppointmentController appointmentController = new AppointmentController();
        public ShowAppointments()
        {
            InitializeComponent();
            appointments = new ObservableCollection<Appointment>(appointmentController.ReadAll());
            AppointmentsGrid.ItemsSource = appointments;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Appointment appointment = AppointmentsGrid.SelectedItem as Appointment;
            int appointmentId = appointment.Id;
            String description = appointment.Descripton;
            int duration = appointment.Duration;
            DateTime dateTime = appointment.DateTime;
            int doctorId = appointment.Doctor.Id;
            int patientId = appointment.Patient.Id;
            int roomId = appointment.Room.Id;
            Boolean emergency = appointment.Emergency;
            appointmentController.UpdateAppointment(dateTime, description, duration, emergency, patientId, doctorId, roomId, appointmentId, false);
            var s = new ShowAppointments();
            s.Show();
            Close();
        }

        private void CreateAppointment_Click(object sender, RoutedEventArgs e)
        {
            var s = new CreateAppointment(appointments);
            s.Show();
            Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Appointment appointment = AppointmentsGrid.SelectedItem as Appointment;
            int appointmentId = appointment.Id;
            appointmentController.DeleteAppointment(appointmentId);
            var s = new ShowAppointments();
            s.Show();
            Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            var s = new ShowPatient();
            s.Show();
            Close();
        }
    }
}
