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
    /// Interaction logic for EditSurgeryData.xaml
    /// </summary>
    public partial class EditSurgeryData : Window
    {
        public EditSurgeryData()
        {
            InitializeComponent();
        }

        private void Potvrdi_Click(object sender, RoutedEventArgs e)
        {
            var s = new ShowSurgery();
            s.Show();
            Close();
        }

        private void Odustani_Click(object sender, RoutedEventArgs e)
        {
            var s = new ShowSurgery();
            s.Show();
            Close();
        }

        private void Type_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Room_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Doctor_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Patient_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Time_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
