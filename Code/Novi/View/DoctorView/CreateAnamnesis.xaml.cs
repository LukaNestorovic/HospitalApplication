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

namespace ProjekatSIMS.View.DoctorView
{
    /// <summary>
    /// Interaction logic for CreateAnamnesis.xaml
    /// </summary>
    public partial class CreateAnamnesis : Window
    {
        public MedicalRecordController medicalRecordController = new MedicalRecordController();
        public CreateAnamnesis()
        {
            InitializeComponent();
        }

        private void CreateAnamnesis1_Click(object sender, RoutedEventArgs e)
        {
            medicalRecordController.createAnamnesis(TBAllergies.Text, Int32.Parse(TBPatientId.Text), TBAnamnesis.Text);
            var s = new ShowAnamnezis();
            s.Show();
            Close();
        }
    }
}
