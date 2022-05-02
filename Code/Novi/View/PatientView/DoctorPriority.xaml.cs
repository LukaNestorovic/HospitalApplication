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
        public DoctorPriority(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = DatePicker.SelectedDate.GetValueOrDefault();
            int doctorId = Int32.Parse(Id.Text);
            appointment = appointmentController.ReadWithPriorityDoctor(doctorId, date);
            appointmentController.UpdateApp(appointment.DateTime, appointment.Descripton, appointment.Duration, appointment.Emergency, id, appointment.Doctor.Id, 1, appointment.Id);
            var s = new PatientView(id);
            s.Show();
            Close();
        }
    }
}
