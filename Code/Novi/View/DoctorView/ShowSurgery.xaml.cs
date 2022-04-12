using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Repository;
using Service;

namespace ProjekatSIMS.View.DoctorView
{
    /// <summary>
    /// Interaction logic for ShowSurgery.xaml
    /// </summary>
    public partial class ShowSurgery : Window
    {


        public ShowSurgery()
        {
            InitializeComponent();

        }

        private void ScheduleSurgery_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void EditSugery_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void CancelSurgery_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new DoctorView();
            s.Show();
            Close();
        }
    }
}
