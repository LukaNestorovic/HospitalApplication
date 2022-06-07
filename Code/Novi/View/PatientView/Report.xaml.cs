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
using Model;
using Controller;
using DTO;
using Appointments.Model;
using Appointments.Controller;
using Appointments.DTO;

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for Report.xaml
    /// </summary>
    public partial class Report : Page
    {
        public Appointment appointment = new Appointment();
        public int id;
        public AppointmentDTO appointmentDTO = new AppointmentDTO();
        public AppointmentController appointmentController = new AppointmentController();
        public Report(Appointment appointment, int id)
        {
            InitializeComponent();
            TBAnamnesis.Text = appointment.Anamnesis;
            this.id = id;
            this.appointment = appointment;
            TBComment.Text = appointment.Comment;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new FinishedExaminations(id);
            NavigationService.Navigate(s);
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            appointmentDTO.DateTime = appointment.DateTime;
            appointmentDTO.Descripton = appointment.Descripton;
            appointmentDTO.Duration = appointment.Duration;
            appointmentDTO.Emergency = appointment.Emergency;
            appointmentDTO.Patient = appointment.Patient;
            appointmentDTO.Doctor = appointment.Doctor;
            appointmentDTO.Room = appointment.Room;
            appointmentDTO.Finished = appointment.Finished;
            appointmentDTO.Comment = TBComment.Text;
            appointmentDTO.Anamnesis = appointment.Anamnesis;

            appointmentController.UpdateAppointment(appointmentDTO, appointment.Id);
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
