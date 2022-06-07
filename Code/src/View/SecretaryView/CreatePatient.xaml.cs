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
using DTO;
using Appointments.Model;
using Appointments.Controller;
using Appointments.DTO;

namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for CreatePatient.xaml
    /// </summary>
    public partial class CreatePatient : Window, INotifyPropertyChanged
    {
        public PatientController patientController = new PatientController();
        public ObservableCollection<Patient> patients;
        public PatientDTO patientDTO = new PatientDTO();

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string n)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(n));
            }
        }

        public CreatePatient(ObservableCollection<Patient> patients) {
            InitializeComponent();
            this.patients = patients;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            patientDTO.Name = TBName.Text;
            patientDTO.Surname = TBSurname.Text;
            patientDTO.Jmbg = TBJmbg.Text;
            patientDTO.Telephone = TBTelephone.Text;
            patientDTO.Email = TBEmail.Text;
            patientDTO.BirthDate = DPBirthDate.SelectedDate.GetValueOrDefault();
            patientDTO.Adress = TBAdress.Text;
            patientDTO.InsuranceCarrier = TBInsurance.Text;
            patientDTO.Guest = (Boolean)CBGuest.IsChecked;
            patientDTO.Password = TBPassword.Text;
            patientDTO.Brojac = 0;
            patientController.CreatePatient(patientDTO);
            var s = new ShowPatient();
            s.Show();
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void textBoxStreetNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}