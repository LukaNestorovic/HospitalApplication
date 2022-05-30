using Controller;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for EditPatient.xaml
    /// </summary>
    public partial class EditPatient : Window
    {
        public PatientController patientController = new PatientController();
        public ObservableCollection<Patient> patients;
        public EditPatient(ObservableCollection<Patient> patients)
        {
            InitializeComponent();
            this.patients = patients;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            patientController.UpdatePatient(TBName.Text, TBSurname.Text, TBJmbg.Text, TBTelephone.Text, TBEmail.Text, DPBirthDate.SelectedDate.GetValueOrDefault(), TBAdress.Text, TBInsurance.Text, (Boolean)CBGuest.IsChecked, false, Int32.Parse(TBId.Text), TBPassword.Text, 0);
            var s = new ShowPatient();
            s.Show();
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var s = new ShowPatient();
            s.Show();
            Close();
        }
    }
}
