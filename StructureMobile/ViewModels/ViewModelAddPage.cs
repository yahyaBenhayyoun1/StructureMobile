using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using StructureMobile.Models;
using StructureMobile.Views;
using Xamarin.Forms;

namespace StructureMobile.ViewModels
{
    public class ViewModelAddPage
    {

        private string productName;
        public string ProductName
        {
            get { return productName; }
            set
            {
                productName = value;
                OnPropertyChanged("productName");
            }
        }


        private string productDescription;
        public string ProductDescription
        {
            get { return productDescription; }
            set
            {
                productDescription = value;
                OnPropertyChanged("productDescription");
            }
        }


        private int productPrice;
        public int ProductPrice
        {
            get { return productPrice; }
            set
            {
                productPrice = value;
                OnPropertyChanged("productPrice");
            }
        }


        public Command SaveProductCommand { get; set; }

        public ObservableCollection<Product> Products { get; set; }


        public ViewModelAddPage()
        {
            SaveProductCommand = new Command(InsertProduct);



        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
 
        }



        public void InsertProduct() 
        {
            Product product = new Product()
            {
                Name = productName,
                Description = productDescription,
                Price =productPrice,
            };

        int response = Product.InsertProduct(product);

            if (response > 0)
                Application.Current.MainPage.Navigation.PopAsync();
            else
                Application.Current.MainPage.DisplayAlert("Error", "No items were inserted", "OK");


        }



 

    }
}
