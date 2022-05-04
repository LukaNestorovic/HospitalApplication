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
using Model;

namespace ProjekatSIMS.View.ManagerView
{
    /// <summary>
    /// Interaction logic for LogInManager.xaml
    /// </summary>
    public partial class LogInManager : Window
    {
        public DeanController deanController = new DeanController();
        public Dean dean = new Dean();
        public LogInManager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dean = deanController.ReadDeanByEmail(TBEmail.Text);
            if (dean.Password == TBPass.Text && dean != null)
            {
                int id = dean.Id;
                var s = new ManagerView();
                s.Show();
                Close();
            }
        }
    }
}
