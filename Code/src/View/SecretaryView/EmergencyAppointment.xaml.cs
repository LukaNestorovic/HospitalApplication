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
using Appointments.Model;
using Appointments.Controller;

namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for EmergencyAppointment.xaml
    /// </summary>
    public partial class EmergencyAppointment : Window
    {
        public DoctorController doctorController = new DoctorController();
        public ObservableCollection<Doctor> doctors = new ObservableCollection<Doctor>();
        public EmergencyAppointment()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            List<Doctor> freeDoctors = doctorController.ReadDoctorsBySpecialityAndFreeAppointment(TBSpeciality.Text);
            foreach (Doctor doctor in freeDoctors)
            {
                doctors.Add(doctor);
            }
            int patientId = Int32.Parse(TBPatient.Text);
            var s = new EmergencyAppointmentList(patientId, doctors);
            s.Show();
            Close();
        }
    }
}
