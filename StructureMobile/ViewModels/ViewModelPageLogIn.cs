using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using StructureMobile.Models;
using StructureMobile.Services;
using StructureMobile.Views;
using Xamarin.Forms;

using StructureMobile.Utils;

namespace StructureMobile.ViewModels
{
    public class ViewModelPageLogIn 
    {
        private string personName;
        public string PersonName
        {
            get { return personName; }
            set
            {
                personName = value;
                Settings.UserName = value;
                OnPropertyChanged("PersonName");
            }
        }

    

        private string personPasseword;
        public string PersonPasseword
        {
            get { return personPasseword; }
            set
            {
                personPasseword = value;
                OnPropertyChanged("personPasseword");
            }
        }


       

       

        public Command LogInCommande { get; set;}

        public Command RegisterCommande { get; set; }

        public ObservableCollection<Person> Persons { get; set; }

        public Command OpenDepService { get; set; }

        public Command UploadImageCommande { get; set; }

        public Command ButtonCommande { get; set; }

        public Command GeolocationCommande { get; set; }





        public ViewModelPageLogIn()
        {
            Persons = new ObservableCollection<Person>();

            LogInCommande = new Command(LogIn_Clicked);

            RegisterCommande = new Command(Register_Clicked);

            OpenDepService = new Command(OpenDep);

            ButtonCommande = new Command(OpenButton);

            UploadImageCommande = new Command(UploadImage_Clicked);

            GeolocationCommande = new Command(OpenGeo_Clicked);

            PersonName = Settings.UserName;


        }

     

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }




        private void LogIn_Clicked(object obj)
        {

            LogInPerson();

        }


        private void Register_Clicked(object obj)
        {

       
            Application.Current.MainPage.Navigation.PushAsync(new PageRegister());
        }



        private void OpenDep(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new DepServicePage());
        }


        private void UploadImage_Clicked(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new PhotoPicker());
        }


        private void OpenButton(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new ButtonPage());
        }


        private void OpenGeo_Clicked(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Geolocalisation());
        }



        private void LogInPerson()
        {

            Person person = new Person()
            {
                Name = personName,
                Passeword = personPasseword,
            };

            string token = LoginService.Login(person.Name, person.Passeword);

            if(token == "TOCKEN") {
                Settings.AccesToken = token;

                Application.Current.MainPage.DisplayAlert("Login OK", "Login OK ", "OK");
                Application.Current.MainPage.Navigation.PushAsync(new MainPage());
            }
            else

                Application.Current.MainPage.DisplayAlert("NO Login", "No Ok", "OK");


        }



    }
}
