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
    /// Interaction logic for PickDate.xaml
    /// </summary>
    public partial class PickDate : Window
    {
        private int id;
        public PickDate(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = DatePicker.SelectedDate.GetValueOrDefault();
            var s = new FreeAppointments(id, date);
            s.Show();
            Close();
        }
    }
}
