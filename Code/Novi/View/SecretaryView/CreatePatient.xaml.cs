using Controller;
using Model;
using Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
/*
namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for CreatePatient.xaml
    /// </summary>
    public partial class CreatePatient : Window, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string n)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(n));
            }
        }

        private string name;
        private string surname;
        private string jmbg;
        private string email;
        private string street;
        private string streetnumber;
        private string country;
        private string city;
        private string username;
        private string password;
        private string lbo;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != name)
                {
                    name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                if (value != surname)
                {
                    surname = value;
                    OnPropertyChanged("Surname");
                }
            }
        }

        public string Jmbg
        {
            get
            {
                return jmbg;
            }
            set
            {
                if (value != jmbg)
                {
                    jmbg = value;
                    OnPropertyChanged("Jmbg");
                }
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value != email)
                {
                    email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                if (value != street)
                {
                    street = value;
                    OnPropertyChanged("Ulica");
                }
            }
        }
        public string StreetNumber
        {
            get
            {
                return streetnumber;
            }
            set
            {
                if (value != streetnumber)
                {
                    streetnumber = value;
                    OnPropertyChanged("StreetNumber");
                }
            }
        }

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (value != country)
                {
                    city = value;
                    OnPropertyChanged("Country");
                }
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                if (value != city)
                {
                    city = value;
                    OnPropertyChanged("City");
                }
            }
        }


        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (value != username)
                {
                    username = value;
                    OnPropertyChanged("Username");
                }
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value != password)
                {
                    password = value;
                    OnPropertyChanged("Password");
                }
            }
        }

        private PatientAccountController patientAccountController = new PatientAccountController();
        private ObservableCollection<Patient> patients;
        private UtilityService utilityService = new UtilityService();

        public CreatePatient(ObservableCollection<Patient> patients) {
            InitializeComponent();
            this.patients = patients;
            DataContext = this;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            User user = new User(textBoxUsername.Text, textBoxPassword.Password);

            Address address = new Address(textBoxCountry.Text, textBoxCity.Text, textBoxStreet.Text, textBoxStreetNumber.Text);

            Person person = new Person(textBoxName.Text, textBoxSurname.Text, textBoxJmbg.Text, textBoxEmail.Text, datePickerDatumRodjenja.SelectedDate.GetValueOrDefault(), address, (bool)radioButtonGenderM.IsChecked ? Gender.Male : Gender.Female);

            string im = textBoxName.Text;
            string pw = textBoxPassword.Password;
            //Person person, string lbo, MedicalRecord medicalrecord
            // Ova polja iz Pacijenta se koriste samo u kartonu
            Patient patient = new Patient(person, lbo, new MedicalRecord());

            if (patientAccountController.CreatePatient(patient)) {
                patients.Add(patient);
                Close();
            }
           
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void textBoxStreetNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
*/