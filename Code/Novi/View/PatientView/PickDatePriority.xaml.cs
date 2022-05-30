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

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for PickDatePriority.xaml
    /// </summary>
    public partial class PickDatePriority : Window
    {
        private int id;
        public Appointment appointment = new Appointment();
        public AppointmentController appointmentController = new AppointmentController();
        public AppointmentDTO appointmentDTO = new AppointmentDTO();
        public PatientController patientController = new PatientController();
        public Patient patient = new Patient();
        public PickDatePriority(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = DatePicker.SelectedDate.GetValueOrDefault();
            appointment = appointmentController.ReadWithPriority(date);
            patient = patientController.ReadPatient(id);
            appointmentDTO.DateTime = appointment.DateTime;
            appointmentDTO.Descripton = appointment.Descripton;
            appointmentDTO.Duration = appointment.Duration;
            appointmentDTO.Emergency = appointment.Emergency;
            appointmentDTO.Doctor = appointment.Doctor;
            appointmentDTO.Room = appointment.Room;
            appointmentDTO.Patient = patient;
            appointmentDTO.Finished = false;
            appointmentController.UpdateAppointment(appointmentDTO, appointment.Id);
            var s = new PatientView(id, 0);
            s.Show();
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
