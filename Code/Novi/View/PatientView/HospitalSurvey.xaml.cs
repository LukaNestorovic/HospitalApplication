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
    /// Interaction logic for HospitalSurvey.xaml
    /// </summary>
    public partial class HospitalSurvey : Window
    {
        private int id;
        public HospitalSurveyController hospitalSurveyController = new HospitalSurveyController();
        public Patient patient = new Patient();
        public PatientController patientController = new PatientController();
        public HospitalSurveyDTO hospitalSurveyDTO = new HospitalSurveyDTO();
        public HospitalSurvey(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            if (Combo1.SelectedIndex == 0)
                hospitalSurveyDTO.Question1 = 1;
            else if (Combo1.SelectedIndex == 1)
                hospitalSurveyDTO.Question1 = 2;
            else if (Combo1.SelectedIndex == 2)
                hospitalSurveyDTO.Question1 = 3;
            else if (Combo1.SelectedIndex == 3)
                hospitalSurveyDTO.Question1 = 4;
            else if (Combo1.SelectedIndex == 4)
                hospitalSurveyDTO.Question1 = 5;
            if (Combo2.SelectedIndex == 0)
                hospitalSurveyDTO.Question2 = 1;
            else if (Combo2.SelectedIndex == 1)
                hospitalSurveyDTO.Question2 = 2;
            else if (Combo2.SelectedIndex == 2)
                hospitalSurveyDTO.Question2 = 3;
            else if (Combo2.SelectedIndex == 3)
                hospitalSurveyDTO.Question2 = 4;
            else if (Combo2.SelectedIndex == 4)
                hospitalSurveyDTO.Question2 = 5;
            if (Combo3.SelectedIndex == 0)
                hospitalSurveyDTO.Question3 = 1;
            else if (Combo3.SelectedIndex == 1)
                hospitalSurveyDTO.Question3 = 2;
            else if (Combo3.SelectedIndex == 2)
                hospitalSurveyDTO.Question3 = 3;
            else if (Combo3.SelectedIndex == 3)
                hospitalSurveyDTO.Question3 = 4;
            else if (Combo3.SelectedIndex == 4)
                hospitalSurveyDTO.Question3 = 5;
            hospitalSurveyDTO.patient = patientController.ReadPatient(id);
            hospitalSurveyController.CreateHospitalSurvey(hospitalSurveyDTO);
            var s = new PatientHome(id);
            s.Show();
            Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new PatientHome(id);
            s.Show();
            Close();
        }
    }
}
