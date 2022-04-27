using ProjekatSIMS.View.DoctorView;
using ProjekatSIMS.View.ManagerView;
using ProjekatSIMS.View.PatientView;
using ProjekatSIMS.View.SecretaryView;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjekatSIMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Doctor_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogInDoctor();
            s.Show();
            Close();
        }

        private void Secretary_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogInSecretary();
            s.Show();
            Close();
        }

        private void Patient_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogInPatient();
            s.Show();
            Close();
        }

        private void Manager_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogInManager();
            s.Show();
            Close();
        }
    }
}
