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
using ProjekatSIMS.View.PatientView;
using ProjekatSIMS.View.DoctorView;
using ProjekatSIMS.View.ManagerView;
using ProjekatSIMS.View.SecretaryView;

namespace ProjekatSIMS
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public PatientController patientController = new PatientController();
        public Patient patient = new Patient();
        public DoctorController doctorController = new DoctorController();
        public Model.Doctor doctor = new Model.Doctor();
        public DeanController deanController = new DeanController();
        public Dean dean = new Dean();
        public SecretaryController secretaryController = new SecretaryController();
        public Secretary secretary = new Secretary();
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Combo.SelectedIndex == 0)
            {
                patient = patientController.ReadPatientByEmail(TBEmail.Text);
                if (patient == null)
                {
                    MessageBox.Show("Pogresan mail ili sifra", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if (patient.Password == TBPass.Text && patient != null)
                {
                    int id = patient.Id;
                    var s = new PatientHome(id);
                    s.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Pogresan mail ili sifra", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else if(Combo.SelectedIndex == 1)
            {
                doctor = doctorController.ReadDoctorByEmail(TBEmail.Text);
                if (doctor == null)
                {
                    MessageBox.Show("Pogresan mail ili sifra", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if (doctor.Password == TBPass.Text && doctor != null)
                {
                    int id = doctor.Id;
                    var s = new DoctorView(id);
                    s.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Pogresan mail ili sifra", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else if(Combo.SelectedIndex == 2)
            {
                dean = deanController.ReadDeanByEmail(TBEmail.Text);
                if (dean == null)
                {
                    MessageBox.Show("Pogresan mail ili sifra", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if (dean.Password == TBPass.Text && dean != null)
                {
                    int id = dean.Id;
                    var s = new ManagerView();
                    s.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Pogresan mail ili sifra", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else if(Combo.SelectedIndex == 3)
            {
                secretary = secretaryController.ReadSecretaryByEmail(TBEmail.Text);
                if (secretary == null)
                {
                    MessageBox.Show("Pogresan mail ili sifra", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if (secretary.Password == TBPass.Text && secretary != null)
                {
                    int id = secretary.Id;
                    var s = new ShowPatient();
                    s.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Pogresan mail ili sifra", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }

        }
    }
}
