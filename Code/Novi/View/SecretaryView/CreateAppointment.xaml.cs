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
using DTO;
using Appointments.Model;
using Appointments.Controller;
using Appointments.DTO;


namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for CreateAppointment.xaml
    /// </summary>
    public partial class CreateAppointment : Window
    {
        public AppointmentController appointmentController = new AppointmentController();
        public ObservableCollection<Appointment> appointments;
        public AppointmentDTO appointmentDTO = new AppointmentDTO();
        public RoomController roomController = new RoomController();
        public DoctorController doctorController = new DoctorController();
        public PatientController patientController = new PatientController();
        public CreateAppointment(ObservableCollection<Appointment> appointments)
        {
            InitializeComponent();
            this.appointments = appointments;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var s = new ShowAppointments();
            s.Show();
            Close();


        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            appointmentDTO.DateTime = DatePicker.SelectedDate.GetValueOrDefault();
            appointmentDTO.Descripton = TBDescription.Text;
            appointmentDTO.Duration = Int32.Parse(TBDuration.Text);
            appointmentDTO.Emergency = (Boolean)CBEmergency.IsChecked;
            appointmentDTO.Patient = patientController.ReadPatient(Int32.Parse(TBPatient.Text));
            appointmentDTO.Doctor = doctorController.ReadDoctor(Int32.Parse(TBDoctor.Text));
            appointmentDTO.Room = roomController.ReadRoom(Int32.Parse(TBRoom.Text));
            appointmentDTO.Finished = false;
            appointmentController.CreateAppointment(appointmentDTO);
            var s = new ShowAppointments();
            s.Show();
            Close();
        }
    }
}
