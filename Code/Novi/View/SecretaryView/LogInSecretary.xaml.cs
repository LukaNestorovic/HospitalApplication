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


namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for LogInSecretary.xaml
    /// </summary>
    public partial class LogInSecretary : Window
    {
        public SecretaryController secretaryController = new SecretaryController();
        public Secretary secretary = new Secretary();
        public LogInSecretary()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            secretary = secretaryController.ReadSecretaryByEmail(TBEmail.Text);
            if (secretary == null)
            {
                var s = new LogInSecretary();
                s.Show();
                Close();
            }
            else if (secretary.Password == TBPass.Text && secretary != null)
            {
                int id = secretary.Id;
                var s = new ShowPatient();
                s.Show();
                Close();
            }
        }
    }
}
