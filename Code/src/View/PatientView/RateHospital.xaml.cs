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
using Appointments.Model;
using Appointments.Controller;

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for RateHospital.xaml
    /// </summary>
    public partial class RateHospital : Page
    {
        private int id;
        public HospitalSurveyController hospitalSurveyController = new HospitalSurveyController();
        public Patient patient = new Patient();
        public PatientController patientController = new PatientController();
        public HospitalSurveyDTO hospitalSurveyDTO = new HospitalSurveyDTO();
        public RateHospital(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            hospitalSurveyDTO.Question1 = Combo1.SelectedIndex + 1;
            hospitalSurveyDTO.Question2 = Combo2.SelectedIndex + 1;
            hospitalSurveyDTO.Question3 = Combo3.SelectedIndex + 1;
            hospitalSurveyDTO.patient = patientController.FindPatientById(id);
            hospitalSurveyController.CreateHospitalSurvey(hospitalSurveyDTO);
            var s = new Home(id);
            NavigationService.Navigate(s);
            
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new Home(id);
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
