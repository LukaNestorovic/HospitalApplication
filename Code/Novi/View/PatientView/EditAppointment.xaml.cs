using Controller;
using Model;
using Repository;
using Service;
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
using Appointments.Controller;
using Appointments.DTO;
using Appointments.Model;


namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for EditAppointment.xaml
    /// </summary>
    public partial class EditAppointment : Page
    {
        public AppointmentController appointmentController = new AppointmentController();
        public DoctorController doctorController = new DoctorController();
        public ObservableCollection<Appointment> appointments;
        private int id;
        public Appointments.Model.Appointment appointment = new Appointments.Model.Appointment();
        public List<Appointments.Model.Doctor> doctors = new List<Appointments.Model.Doctor>();
        public Appointments.Model.Doctor doctor = new Appointments.Model.Doctor();
        public AppointmentDTO appointmentDTO = new AppointmentDTO();
        public RoomController roomController = new RoomController();
        public PatientController patientController = new PatientController();
        public EditAppointment(Appointments.Model.Appointment appointment, int id)
        {
            InitializeComponent();
            DP.SelectedDate = appointment.DateTime;
            Combo.SelectedItem = appointment.Doctor;
            doctors = doctorController.ReadAll();
            Combo.ItemsSource = doctors;
            this.appointment = appointment;
            this.id = id;
        }
        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime today2 = today.AddDays(2);

            if (today2 <= appointment.DateTime)
            {
                doctor = (Appointments.Model.Doctor)Combo.SelectedItem;
                if (doctor == null)
                {
                    MessageBox.Show("Choose doctor", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                        appointmentDTO.DateTime = DP.SelectedDate.GetValueOrDefault();
                        appointmentDTO.Descripton = appointment.Descripton;
                        appointmentDTO.Duration = appointment.Duration;
                        appointmentDTO.Emergency = appointment.Emergency;
                        appointmentDTO.Patient = appointment.Patient;
                        appointmentDTO.Doctor = doctor;
                        appointmentDTO.Room = appointment.Room;
                        appointmentDTO.Finished = false;
                        appointmentDTO.Comment = appointment.Comment;
                        appointmentDTO.Anamnesis = appointment.Anamnesis;

                        appointmentController.UpdateAppointmentAntiTroll(appointmentDTO, appointment.Id);
                        var s = new ScheduledAppointments(id);
                        NavigationService.Navigate(s);
                }
            }
            else
            {
                MessageBox.Show("Manje od dva dana do termina", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var s = new ScheduledAppointments(id);
            NavigationService.Navigate(s);
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
