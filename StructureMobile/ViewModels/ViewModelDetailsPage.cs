using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using StructureMobile.Models;

namespace StructureMobile.ViewModels
{

    public class ViewModelDetailsPage 
    {


        private Product product;
        public Product Product
        {
            get { return product; }
            set
            {
                product = value;
                OnPropertyChanged("Product");
            }
        }


        public ViewModelDetailsPage()
        {


        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }


    }
}
