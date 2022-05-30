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
using DTO;

namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for ShowAppointments.xaml
    /// </summary>
    public partial class ShowAppointments : Window
    {
        public ObservableCollection<Appointment> appointments;
        public AppointmentController appointmentController = new AppointmentController();
        public PatientController patientController = new PatientController();
        public DoctorController doctorController = new DoctorController();
        public RoomController roomController = new RoomController();
        public AppointmentDTO appointmentDTO = new AppointmentDTO();
        public ShowAppointments()
        {
            InitializeComponent();
            appointments = new ObservableCollection<Appointment>(appointmentController.ReadAll());
            AppointmentsGrid.ItemsSource = appointments;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Appointment appointment = AppointmentsGrid.SelectedItem as Appointment;
            appointmentDTO.Descripton = appointment.Descripton;
            appointmentDTO.Duration = appointment.Duration;
            appointmentDTO.DateTime = appointment.DateTime;
            appointmentDTO.Emergency = appointment.Emergency;
            appointmentDTO.Patient = patientController.ReadPatient(appointment.Patient.Id);
            appointmentDTO.Doctor = doctorController.ReadDoctor(appointment.Doctor.Id);
            appointmentDTO.Room = roomController.ReadRoom(appointment.Room.Id);
            appointmentDTO.Finished = false;
            appointmentController.UpdateAppointment(appointmentDTO, appointment.Id);
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
            appointmentController.DeleteAppointment(appointmentId, 1);
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
