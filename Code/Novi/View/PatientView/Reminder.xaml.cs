using Controller;
using Model;
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

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for Reminder.xaml
    /// </summary>
    public partial class Reminder : Page
    {
        public int id;
        public ObservableCollection<Model.Reminder> reminders;
        public ReminderController reminderController = new ReminderController();
        public Model.Reminder reminder = new Model.Reminder();
        public Reminder(int id)
        {
            InitializeComponent();
            reminders = new ObservableCollection<Model.Reminder>(reminderController.FindAll());
            PatientAppointments.ItemsSource = reminders;
            this.id = id;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            var s = new CreateReminder(id);
            NavigationService.Navigate(s);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            reminder = (Model.Reminder)PatientAppointments.SelectedItem;
            if (reminder == null)
            {
                MessageBox.Show("Choose reminder", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                var s = new EditReminder(reminder, id);
                NavigationService.Navigate(s);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            reminder = (Model.Reminder)PatientAppointments.SelectedItem;
            if (reminder == null)
            {
                MessageBox.Show("Choose reminder", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                reminderController.DeleteReminder(reminder.Id);
                var s = new Reminder(id);
                NavigationService.Navigate(s);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new Home(id);
            NavigationService.Navigate(s);
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
