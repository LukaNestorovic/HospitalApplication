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

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for PatientHome.xaml
    /// </summary>
    public partial class PatientHome : Window
    {
        private int id;
        public PatientHome(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Appointments_Click(object sender, RoutedEventArgs e)
        {
            var s = new PatientView(id);
            s.Show();
            Close();
        }

        private void Medicine_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogInPatient();
            s.Show();
            Close();
        }
    }
}
