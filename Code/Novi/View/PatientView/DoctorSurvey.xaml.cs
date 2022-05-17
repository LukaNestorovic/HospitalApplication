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
    /// Interaction logic for DoctorSurvey.xaml
    /// </summary>
    public partial class DoctorSurvey : Window
    {
        private int id;
        public DoctorSurveyController doctorSurveyController = new DoctorSurveyController();
        public Patient patient = new Patient();
        public PatientController patientController = new PatientController();
        public Appointment appointment = new Appointment();
        public Model.Doctor doctor = new Model.Doctor();
        public DoctorSurveyDTO doctorSurveyDTO = new DoctorSurveyDTO();
        public DoctorSurvey(int id, Appointment appointment)
        {
            InitializeComponent();
            this.appointment = appointment;
            this.id = id;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (Combo1.SelectedIndex == 0)
                doctorSurveyDTO.Question1 = 1;
            else if (Combo1.SelectedIndex == 1)
                doctorSurveyDTO.Question1 = 2;
            else if (Combo1.SelectedIndex == 2)
                doctorSurveyDTO.Question1 = 3;
            else if (Combo1.SelectedIndex == 3)
                doctorSurveyDTO.Question1 = 4;
            else if (Combo1.SelectedIndex == 4)
                doctorSurveyDTO.Question1 = 5;
            if (Combo2.SelectedIndex == 0)
                doctorSurveyDTO.Question2 = 1;
            else if (Combo2.SelectedIndex == 1)
                doctorSurveyDTO.Question2 = 2;
            else if (Combo2.SelectedIndex == 2)
                doctorSurveyDTO.Question2 = 3;
            else if (Combo2.SelectedIndex == 3)
                doctorSurveyDTO.Question2 = 4;
            else if (Combo2.SelectedIndex == 4)
                doctorSurveyDTO.Question2 = 5;
            if (Combo3.SelectedIndex == 0)
                doctorSurveyDTO.Question3 = 1;
            else if (Combo3.SelectedIndex == 1)
                doctorSurveyDTO.Question3 = 2;
            else if (Combo3.SelectedIndex == 2)
                doctorSurveyDTO.Question3 = 3;
            else if (Combo3.SelectedIndex == 3)
                doctorSurveyDTO.Question3 = 4;
            else if (Combo3.SelectedIndex == 4)
                doctorSurveyDTO.Question3 = 5;
            doctorSurveyDTO.patient = appointment.Patient;
            doctorSurveyDTO.doctor = appointment.Doctor;
            doctorSurveyController.CreateDoctorSurvey(doctorSurveyDTO);
            var s = new Finished(id);
            s.Show();
            Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new PatientHome(id);
            s.Show();
            Close();
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
            Close();
        }

        private void Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
