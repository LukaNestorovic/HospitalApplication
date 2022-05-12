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

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for ChosePriority.xaml
    /// </summary>
    public partial class ChosePriority : Window
    {
        private int id;
        public ChosePriority(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Doctor_click(object sender, RoutedEventArgs e)
        {
            var s = new DoctorPriority(id);
            s.Show();
            Close();
        }

        private void Time_click(object sender, RoutedEventArgs e)
        {
            var s = new PickDatePriority(id);
            s.Show();
            Close();
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            var s = new PatientView(id);
            s.Show();
            Close();
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
            Close();
        }
    }
}
