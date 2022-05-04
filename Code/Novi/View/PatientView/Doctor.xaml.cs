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


namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for Doctor.xaml
    /// </summary>
    public partial class Doctor : Window
    {
        public DoctorController doctorController = new DoctorController();
        public ObservableCollection<Doctor> doctors;
        public Doctor()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            doctorController.CreateDoctor(TBName.Text, TBSurname.Text, TBJmbg.Text, TBTelephone.Text, TBEmail.Text, DPBirthDate.SelectedDate.GetValueOrDefault(), TBAdress.Text, TBSpecialty.Text, float.Parse(TBGrade.Text), Int32.Parse(TBSalary.Text),TBPassword.Text);
            var s = new LogInPatient();
            s.Show();
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
