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

namespace ProjekatSIMS.View.DoctorView
{
    /// <summary>
    /// Interaction logic for Prescription.xaml
    /// </summary>
    public partial class Prescription : Window
    {
        public PrescriptionController prescriptionController = new PrescriptionController();
        private int id;
        public PrescriptionDTO prescriptionDTO = new PrescriptionDTO();
        public DoctorController doctorController = new DoctorController();
        public PatientController patientController = new PatientController();
        public DrugController drugController = new DrugController();

        public Prescription()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            prescriptionDTO.Instructions = TBInstructions.Text;
            prescriptionDTO.doctor = doctorController.ReadDoctor(Int32.Parse(TBDoctor.Text));
            prescriptionDTO.patient = patientController.ReadPatient(Int32.Parse(TBPatient.Text));
            prescriptionDTO.drug = drugController.ReadDrug(Int32.Parse(TBDrug.Text));
            prescriptionDTO.datetime = DatePicker.SelectedDate.GetValueOrDefault();
            prescriptionController.CreatePrescription(prescriptionDTO);
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new DoctorView(id);
            s.Show();
            Close();
        }
    }
}
