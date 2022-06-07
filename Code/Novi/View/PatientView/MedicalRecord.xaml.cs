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
using Appointments.Model;
using Appointments.Controller;

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for MedicalRecord.xaml
    /// </summary>
    public partial class MedicalRecord : Page
    {
        public int id;
        public Patient patient = new Patient();
        public PatientController patientController = new PatientController();
        public MedicalRecord(int id)
        {
            InitializeComponent();
            this.id = id;
            patient = patientController.ReadPatient(id);
            TBAdress.Text = patient.Adress;
            TBBirth.Text = patient.BirthDate.ToString();
            TBEmail.Text = patient.Email;
            TBName.Text = patient.Name;
            TBSurname.Text = patient.Surname;
            TBTelephone.Text = patient.Telephone;
            TBJmbg.Text = patient.Jmbg;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
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
