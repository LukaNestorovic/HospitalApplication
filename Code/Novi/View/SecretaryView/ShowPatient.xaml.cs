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
using System.Collections.ObjectModel;

namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for ShowAccount.xaml
    /// </summary>
    public partial class ShowPatient : Window
    {
       
        public PatientController patientController = new PatientController();
        public ObservableCollection<Patient> patients;
        public ObservableCollection<MedicalRecord> medicicalRecords;

        public ShowPatient()
        {
            InitializeComponent();
            patients = new ObservableCollection<Patient>(patientController.ReadAll());
            dgDataBinding.ItemsSource = patients;
        }

        private void CreateAccount_Click(object sender, RoutedEventArgs e)
        {
            var s = new CreatePatient(patients);
            s.Show();
            Close();
        }

        private void ShowAccount_Click(object sender, RoutedEventArgs e)
        {
            var s = new ShowPatient();
            s.Show();
            Close();
        }
        private void EditAccount_Click(object sender, RoutedEventArgs e)
        {
            var s = new EditPatient(patients);
            s.Show();
            Close();
        }

        private void DeleteAccount_Click(object sender, RoutedEventArgs e)
        {
            var s = new Delete();
            s.Show();
            
        }

        private void Operations_Click(object sender, RoutedEventArgs e)
        {
            var s = new ShowOperations();
            s.Show();
            Close();
        }

        private void Appointments_Click(object sender, RoutedEventArgs e)
        {
            var s = new ShowAppointments();
            s.Show();
            Close ();
        }

        private void EditAllergens_Click(object sender, RoutedEventArgs e)
        {
            var s = new Allergenes(medicicalRecords);
            s.Show();
            Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
