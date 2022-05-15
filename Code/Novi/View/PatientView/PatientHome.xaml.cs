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

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for PatientHome.xaml
    /// </summary>
    public partial class PatientHome : Window
    {
        private int id;
        public Patient patient = new Patient();
        public PatientController patientController = new PatientController();
        public int brojac = 0;
        public PatientHome(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Appointments_Click(object sender, RoutedEventArgs e)
        {
            var s = new PatientView(id, brojac);
            s.Show();
            Close();
        }

        private void Medicine_Click(object sender, RoutedEventArgs e)
        {
            var s = new Medicine(id);
            s.Show();
            Close();
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
            Close();
        }

        private void Schedule_Click(object sender, RoutedEventArgs e)
        {
            var s = new ChosePriority(id);
            s.Show();
            Close();
        }

        private void MedicalRecord_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Reminder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Rate_Click(object sender, RoutedEventArgs e)
        {
            var s = new HospitalSurvey(id);
            s.Show();
            Close();
        }

        private void Finished_Click(object sender, RoutedEventArgs e)
        {
            var s = new Finished(id);
            s.Show();
            Close();
        }
    }
}
