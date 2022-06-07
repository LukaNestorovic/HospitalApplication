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
using Controller;
using Model;

namespace ProjekatSIMS.View.DoctorView
{
    /// <summary>
    /// Interaction logic for ShowAnamnezis.xaml
    /// </summary>
    public partial class ShowAnamnezis : Window
    {
        public ObservableCollection<MedicalRecord> medicalRecords;
        public MedicalRecordController medicalRecordController = new MedicalRecordController();
        public ShowAnamnezis()
        {
            InitializeComponent();
            medicalRecords = new ObservableCollection<MedicalRecord>(medicalRecordController.readAll());
            AnamnesisGrid.ItemsSource = medicalRecords;

        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            MedicalRecord medicalRecord = AnamnesisGrid.SelectedItem as MedicalRecord;
            int patientId = medicalRecord.patient.Id;
            String anamnesis = medicalRecord.Anamnesis;
            medicalRecordController.updateAnamnesis(patientId, anamnesis);
            var s = new ShowAnamnezis();
            s.Show();
            Close();
        }

        private void WriteAnamnesis_Click(object sender, RoutedEventArgs e)
        {
            var s = new CreateAnamnesis();
            s.Show();
            Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
            Close();
        }
    }
}
