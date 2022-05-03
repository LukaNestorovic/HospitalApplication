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
using System.Collections.ObjectModel;
using Model;
using Controller;

namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for Allergenes.xaml
    /// </summary>
    public partial class Allergenes : Window
    {
        public ObservableCollection<MedicalRecord> medicalRecords;
        public MedicalRecordController medicalRecordController = new MedicalRecordController();
        public PatientController patientController = new PatientController();
        public Allergenes(ObservableCollection<MedicalRecord> medicalRecords)
        {
            InitializeComponent();
            this.medicalRecords = medicalRecords;
        }

   
        public void Submit_Click(object sender, RoutedEventArgs e)
        {
            Patient patient = patientController.ReadPatientByEmail(TBEmail.Text);
            int patientID = patient.Id;
            medicalRecordController.updateAllergies(patientID, TBAllergenes.Text);
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
