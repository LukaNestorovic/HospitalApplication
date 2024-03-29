﻿using System;
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
using Appointments.Model;
using Appointments.Controller;
using Appointments.DTO;

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
        public ObservableCollection<DynamicEquipment> dynamicEquipment;

        public ShowPatient()
        {
            InitializeComponent();
            patients = new ObservableCollection<Patient>(patientController.FindAll());
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
            Close();
        }

        private void EditAllergens_Click(object sender, RoutedEventArgs e)
        {
            var s = new Allergenes();
            s.Show();
            Close();
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
            Close();
        }

        private void dgDataBinding_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddDynamicEquipmentButton_Click(object sender, RoutedEventArgs e)
        {
            var s = new AddDynamicEquipment(dynamicEquipment);
            s.Show();
            Close();
        }

        private void StorageButton_Click(object sender, RoutedEventArgs e)
        {
            var s = new Storage();
            s.Show();
            Close();
        }

        private void EmergencyAppointments_Click(object sender, RoutedEventArgs e)
        {
            var s = new EmergencyAppointment();
            s.Show();
            Close();
        }

        private void EmergencyOperations_Click(object sender, RoutedEventArgs e)
        {
            var s = new EmergencyOperation();
            s.Show();
            Close();
        }
    }
}
