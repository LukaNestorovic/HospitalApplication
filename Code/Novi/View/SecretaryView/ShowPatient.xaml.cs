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
using Repository;
using System.Collections.ObjectModel;
/*
namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for ShowAccount.xaml
    /// </summary>
    public partial class ShowPatient : Window
    {
        private PatientAccountController patientAccountController = new PatientAccountController();
        public PatientAccountRepository patientAccountRepository = new PatientAccountRepository();
        public ObservableCollection<Patient> patients;

        public ShowPatient()
        {
            InitializeComponent();
            patients = new ObservableCollection<Patient>(patientAccountRepository.ShowAllPatients());
            dgDataBinding.ItemsSource = patients;
        }

        private void CreateAccount_Click(object sender, RoutedEventArgs e)
        {
            var s = new CreatePatient(patients);
            s.Show();
        }

        private void ShowAccount_Click(object sender, RoutedEventArgs e)
        {
            var s = new ShowPatient();
            s.Show();
        }
        private void EditAccount_Click(object sender, RoutedEventArgs e)
        {
            var s = new EditPatient();
            s.Show();
        }

        private void DeleteAccount_Click(object sender, RoutedEventArgs e)
        {
            if ((Patient)dgDataBinding.SelectedItem != null) 
            {
                patientAccountController.DeletePatient((Patient)dgDataBinding.SelectedItem);
                patients.Remove((Patient)dgDataBinding.SelectedItem);
            }
            
        }
    }
}
*/