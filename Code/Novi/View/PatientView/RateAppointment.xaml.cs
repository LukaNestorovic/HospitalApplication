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

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for RateAppointment.xaml
    /// </summary>
    public partial class RateAppointment : Page
    {
        private int id;
        public DoctorSurveyController doctorSurveyController = new DoctorSurveyController();
        public Patient patient = new Patient();
        public PatientController patientController = new PatientController();
        public Appointment appointment = new Appointment();
        public Model.Doctor doctor = new Model.Doctor();
        public DoctorSurveyDTO doctorSurveyDTO = new DoctorSurveyDTO();
        public RateAppointment(int id, Appointment appointment)
        {
            InitializeComponent();
            this.appointment = appointment;
            this.id = id;
        }
        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            doctorSurveyDTO.Question1 = Combo1.SelectedIndex + 1;
            doctorSurveyDTO.Question2 = Combo2.SelectedIndex + 1;
            doctorSurveyDTO.Question3 = Combo3.SelectedIndex + 1;
            doctorSurveyDTO.patient = appointment.Patient;
            doctorSurveyDTO.doctor = appointment.Doctor;
            doctorSurveyController.CreateDoctorSurvey(doctorSurveyDTO);
            var s = new FinishedExaminations(id);
            NavigationService.Navigate(s);
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

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            var s = new Help(id);
            NavigationService.Navigate(s);
        }
    }
}
