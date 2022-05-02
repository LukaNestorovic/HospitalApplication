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

namespace ProjekatSIMS.View.DoctorView
{
    /// <summary>
    /// Interaction logic for Drug.xaml
    /// </summary>
    public partial class Drug : Window
    {
        public DrugController drugController = new DrugController();
        public Drug()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            drugController.CreateDrug(TBName.Text, TBIngridients.Text, (Boolean)CB.IsChecked, Int32.Parse(TBDrugnum.Text));
        }
    }
}
