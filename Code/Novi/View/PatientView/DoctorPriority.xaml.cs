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


namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for DoctorPriority.xaml
    /// </summary>
    public partial class DoctorPriority : Window
    {
        private int id;
        public Appointment appointment = new Appointment();
        public AppointmentController appointmentController = new AppointmentController();
        public DoctorController doctorController = new DoctorController();
        public List<Model.Doctor> doctors = new List<Model.Doctor>();
        public Model.Doctor doctor = new Model.Doctor();
        public DoctorPriority(int id)
        {
            InitializeComponent();
            doctors = doctorController.ReadAll();
            Combo.ItemsSource = doctors;
            this.id = id;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = DatePicker.SelectedDate.GetValueOrDefault();
            doctor = (Model.Doctor)Combo.SelectedItem;
            appointment = appointmentController.ReadWithPriorityDoctor(doctor.Id, date);
            appointmentController.UpdateAppointment(appointment.DateTime, appointment.Descripton, appointment.Duration, appointment.Emergency, id, appointment.Doctor.Id, 1, appointment.Id, false);
            var s = new PatientView(id, 0);
            s.Show();
            Close();
        }
    }
}
