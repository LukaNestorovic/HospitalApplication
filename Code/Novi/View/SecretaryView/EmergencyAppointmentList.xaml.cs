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
using DTO;

namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for EmergencyAppointmentList.xaml
    /// </summary>
    public partial class EmergencyAppointmentList : Window
    {
        private int patientId;
        public ObservableCollection<Doctor> freeDoctors;
        public AppointmentController appointmentController = new AppointmentController();
        public AppointmentDTO appointmentDTO = new AppointmentDTO();
        public RoomController roomController = new RoomController();
        public PatientController patientController = new PatientController();
        public DoctorController doctorController = new DoctorController();
        public EmergencyAppointmentList(int patientId, ObservableCollection<Doctor> freeDoctors)
        {
            InitializeComponent();
            this.patientId = patientId;
            this.freeDoctors = freeDoctors;
            EmergencyAppointmentsGrid.ItemsSource = freeDoctors;
        }

        private void Schedule_Click(object sender, RoutedEventArgs e)
        {
            Doctor doctor = EmergencyAppointmentsGrid.SelectedItem as Doctor;
            int doctorId = doctor.Id;
            appointmentDTO.DateTime = DateTime.Now.AddHours(1);
            appointmentDTO.Descripton = "emergency";
            appointmentDTO.Room = roomController.ReadRoom(1);
            appointmentDTO.Emergency = true;
            appointmentDTO.Doctor = doctorController.ReadDoctor(doctorId);
            appointmentDTO.Patient = patientController.ReadPatient(patientId);
            appointmentDTO.Duration = 1;

            appointmentController.CreateAppointment(appointmentDTO);
            MessageBox.Show("Termin je uspesno zakazan");
            freeDoctors.Remove(doctor);
        }
    }
}
