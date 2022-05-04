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
    /// Interaction logic for PatientList.xaml
    /// </summary>
    public partial class PatientList : Window
    {
        public ObservableCollection<Patient> patients;
        public PatientController patientController = new PatientController();

        private int id;
        public PatientList(int id)
        {
            InitializeComponent();
            patients = new ObservableCollection<Patient>(patientController.ReadAll());
            dgDataBinding.ItemsSource = patients;
            this.id = id;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new DoctorView(id);
            s.Show();
            Close();
        }

        private void dgDataBinding_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
