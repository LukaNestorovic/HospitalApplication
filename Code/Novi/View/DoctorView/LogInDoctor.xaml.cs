using Model;
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
using Controller;
using Model;

namespace ProjekatSIMS.View.DoctorView
{
    /// <summary>
    /// Interaction logic for LogInDoctor.xaml
    /// </summary>
    public partial class LogInDoctor : Window
    {
        public DoctorController doctorController = new DoctorController();
        public Doctor doctor = new Doctor();
        public LogInDoctor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            doctor = doctorController.ReadDoctorByEmail(TBEmail.Text);
            if (doctor == null)
            {
                var s = new LogInDoctor();
                s.Show();
                Close();
            }
            else if(doctor.Password == TBPass.Text && doctor != null)
            {
                int id = doctor.Id;
                var s = new DoctorView(id);
                s.Show();
                Close();
            }
        }
    }
}
