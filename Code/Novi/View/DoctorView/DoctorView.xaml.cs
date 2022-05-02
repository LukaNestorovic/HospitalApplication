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

namespace ProjekatSIMS.View.DoctorView
{
    /// <summary>
    /// Interaction logic for DoctorView.xaml
    /// </summary>
    public partial class DoctorView : Window
    {
        public DoctorView()
        {
            InitializeComponent();
        }

        private void SurgeryList_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void ShowSurgery_Click(object sender, RoutedEventArgs e)
        {
            var s = new ShowSurgery();
            s.Show();
            Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new MainWindow();
            s.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = new Prescription();
            s.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var s = new Drug();
            s.Show();
            Close();
        }
    }
}
