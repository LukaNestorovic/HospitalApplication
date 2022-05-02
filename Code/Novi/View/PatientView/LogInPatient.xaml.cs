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
using Controller;
using Model;

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for LogInPatient.xaml
    /// </summary>
    public partial class LogInPatient : Window
    {
        public PatientController patientController = new PatientController();
        public Patient patient = new Patient();
        public LogInPatient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            patient = patientController.ReadPatientByEmail(TBEmail.Text);
            if(patient.Password == TBPass.Text && patient != null)
            {
                int id = patient.Id;
                var s = new PatientHome(id);
                s.Show();
                Close();
            }
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var s = new Doctor();
            s.Show();
            Close();
        }
    }
}
