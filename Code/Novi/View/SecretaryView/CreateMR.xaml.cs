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
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for CreateMR.xaml
    /// </summary>
    public partial class CreateMR : Window
    {
        public MedicalRecordController medicalRecordController = new MedicalRecordController();
        public PatientController patientController = new PatientController();
        public ObservableCollection<MedicalRecord> medicalRecords;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string n)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(n));
            }
        }
        public CreateMR(ObservableCollection<MedicalRecord> medicalRecords)
        {
            InitializeComponent();
            this.medicalRecords = medicalRecords;
        }

        private void Kreiraj_Click(object sender, RoutedEventArgs e)
        {
            medicalRecordController.createMR(TBAllergies.Text, Int32.Parse(TBPatient.Text));
            var s = new ShowPatient();
            s.Show();
            Close();
        }
    }
}
