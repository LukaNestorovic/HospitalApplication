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

namespace ProjekatSIMS.View.DoctorView
{
    /// <summary>
    /// Interaction logic for Prescription.xaml
    /// </summary>
    public partial class Prescription : Window
    {
        public PrescriptionController prescriptionController = new PrescriptionController();
        private int id;

        public Prescription()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            prescriptionController.CreatePrescription(TBInstructions.Text, Int32.Parse(TBDoctor.Text), Int32.Parse(TBPatient.Text), Int32.Parse(TBDrug.Text), DatePicker.SelectedDate.GetValueOrDefault());
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new DoctorView(id);
            s.Show();
            Close();
        }
    }
}
