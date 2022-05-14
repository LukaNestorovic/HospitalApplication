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
        public HospitalSurvey(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            int question1 = new int();
            int question2 = new int();
            int question3 = new int();
            if (Combo1.SelectedIndex == 0)
                question1 = 1;
            else if (Combo1.SelectedIndex == 1)
                question1 = 2;
            else if (Combo1.SelectedIndex == 2)
                question1 = 3;
            else if (Combo1.SelectedIndex == 3)
                question1 = 4;
            else if (Combo1.SelectedIndex == 4)
                question1 = 5;
            if (Combo2.SelectedIndex == 0)
                question2 = 1;
            else if (Combo2.SelectedIndex == 1)
                question2 = 2;
            else if (Combo2.SelectedIndex == 2)
                question2 = 3;
            else if (Combo2.SelectedIndex == 3)
                question2 = 4;
            else if (Combo2.SelectedIndex == 4)
                question2 = 5;
            if (Combo3.SelectedIndex == 0)
                question3 = 1;
            else if (Combo3.SelectedIndex == 1)
                question3 = 2;
            else if (Combo3.SelectedIndex == 2)
                question3 = 3;
            else if (Combo3.SelectedIndex == 3)
                question3 = 4;
            else if (Combo3.SelectedIndex == 4)
                question3 = 5;
            patient = patientController.ReadPatient(id);
            hospitalSurveyController.CreateHospitalSurvey(question1, question2, question3, patient);
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
