using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using StructureMobile.Models;
using Xamarin.Forms;

namespace StructureMobile.ViewModels
{
    public class ViewModelPageRegister 
    {

        private string personeName { get; set; }
        public string PersoneName
        {
            get { return personeName; }
            set
            {
                personeName = value;
                OnPropertyChanged("PersoneName");
            }
        }

        private string personePasseword;
        public string PersonePasseword
        {
            get { return personePasseword; }
            set
            {
                personePasseword = value;
                OnPropertyChanged("PersonePasseword");
            }
        }


        private int personeAge;
        public int PersoneAge
        {
            get { return personeAge; }
            set
            {
                personeAge = value;
                OnPropertyChanged("PersoneAge");
            }
        }



        public Command SavePersonCommand { get; set; }

        public ObservableCollection<Person> Persons { get; set; }



        public ViewModelPageRegister()
        {
            SavePersonCommand = new Command(InsertPerson);

        }




        public void InsertPerson()
        {
            Person person = new Person()
            {
                Name = PersoneName,
                Passeword = PersonePasseword,
                Age = PersoneAge,
            };

            int response = Person.InsertPerson(person);

            if (response > 0)
                Application.Current.MainPage.Navigation.PopAsync();


            else
                Application.Current.MainPage.DisplayAlert("Error", "No items were inserted", "OK");


        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }


    }
}
