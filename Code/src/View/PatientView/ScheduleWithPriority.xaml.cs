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
using DTO;
using Appointments.Model;
using Appointments.Controller;
using Appointments.DTO;


namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for ScheduleWithPriority.xaml
    /// </summary>
    public partial class ScheduleWithPriority : Page
    {
        private int id;
        public Appointment appointment = new Appointment();
        public AppointmentController appointmentController = new AppointmentController();
        public AppointmentDTO appointmentDTO = new AppointmentDTO();
        public PatientController patientController = new PatientController();
        public Patient patient = new Patient();
        public List<Appointments.Model.Doctor> doctors = new List<Appointments.Model.Doctor>();
        public Appointments.Model.Doctor doctor = new Appointments.Model.Doctor();
        public DoctorController doctorController = new DoctorController();
        public ScheduleWithPriority(int id)
        {
            InitializeComponent();
            doctors = doctorController.ReadAll();
            Combo.ItemsSource = doctors;
            this.id = id;
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            var s = new Home(id);
            NavigationService.Navigate(s); 
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show(); 
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if(Combo.Visibility != Visibility.Visible)
            {
                DateTime date = DatePicker1.SelectedDate.GetValueOrDefault();
                appointment = appointmentController.FindWithDatePriority(date);
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
            else
            {
                DateTime date = DatePicker1.SelectedDate.GetValueOrDefault();
                doctor = (Appointments.Model.Doctor)Combo.SelectedItem;
                patient = patientController.FindPatientById(id);
                appointment = appointmentController.FindWithDoctorPriority(doctor.Id, date);
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

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            String naslov = (String)LNaslov.Content;
            var s = new ProjekatSIMS.Help(naslov);
            s.Show();
        }

        private void RBTime_Checked(object sender, RoutedEventArgs e)
        {
            LabelDoctor.Visibility = Visibility.Hidden;
            DatePicker1.Visibility = Visibility.Visible;
            Combo.Visibility = Visibility.Hidden;
            Submit.Visibility = Visibility.Visible;
        }

        private void RBDoctor_Checked(object sender, RoutedEventArgs e)
        {
            LabelDoctor.Visibility = Visibility.Visible;
            DatePicker1.Visibility = Visibility.Visible;
            Combo.Visibility = Visibility.Visible;
            Submit.Visibility = Visibility.Visible;
        }
    }
}
