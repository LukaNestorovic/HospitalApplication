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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Model;
using Controller;
using System.Globalization;
using Appointments.Model;

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for Note.xaml
    /// </summary>
    public partial class Note : Page
    {
 //       public int id;
 //       public Appointment appointment = new Appointment();
        public Note(Appointment appointment, int id)
        {
            var sw = Application.Current.Windows
            .Cast<Window>()
            .FirstOrDefault(window => window is LogIn) as LogIn;

            this.DataContext = new ViewModel.NoteVM(sw.MainFrame.NavigationService, id, appointment);
            InitializeComponent();
/*            TBAnamnesis.Text = appointment.Anamnesis;
            TBDate.Text = DateTime.Now.ToString();
            TBName.Text = appointment.Patient.Name;
            TBSurname.Text = appointment.Patient.Surname;
            TBNameDoctor.Text = appointment.Doctor.Name;
            TBSurnameDoctor.Text = appointment.Doctor.Surname;
            this.id = id;
            this.appointment = appointment;*/
        }

/*        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Stampanje uspesno", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            var s = new FinishedExaminations(id);
            NavigationService.Navigate(s);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new FinishedExaminations(id);
            NavigationService.Navigate(s);
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            String naslov = (String)LNaslov.Content;
            var s = new ProjekatSIMS.Help(naslov);
            s.Show();
        }*/
    }
}
