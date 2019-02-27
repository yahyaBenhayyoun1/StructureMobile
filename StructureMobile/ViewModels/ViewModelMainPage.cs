using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using StructureMobile.Models;
using StructureMobile.Views;
using Xamarin.Forms;
using StructureMobile.Utils;

namespace StructureMobile.ViewModels
{
    public class ViewModelMainPage 
    {

        public Command AddProductCommand { get; set; }

        public Command LogOutCommand { get; set; }

        public List<Product> Productlist { get; set; }

         
        public ObservableCollection<Product> Products { get; set; }




        public ViewModelMainPage()
        {
          

            Products = new ObservableCollection<Product>();

            AddProductCommand = new Command(Add_Clicked);

            LogOutCommand = new Command(OnLogout);

            GetProduct();

          /* Personslist = new List<Person>
            {
            new Person
            {
                Name = "Houssem",
                Passeword = "123456",
              Age = 24,
               },


                new Person
            {
                Name = "Mohamed",
                Passeword = "123456",
              Age = 17,
               },



                    new Person
            {
                Name = "Yahya",
                Passeword = "123456",
              Age = 35,
               },



            };*/



    }

        private void Add_Clicked(object obj)
        {

            Application.Current.MainPage.Navigation.PushAsync(new AddList());
        }


        private void OnLogout(object obj)
        {
            Settings.AccesToken = string.Empty;
            Application.Current.MainPage.Navigation.PushAsync(new PageLogIn());

        }


        public void GetProduct()
        {
            var products = Product.GetProduct();
            // products = products.Where((product) => product.Name.Contains("Test")).ToList();
            products = products.OrderByDescending((product) => product.Price).ToList();
            Products.Clear();

            foreach (var product in products)
            {
                Products.Add(product);
            }

        }

     

    }
}
