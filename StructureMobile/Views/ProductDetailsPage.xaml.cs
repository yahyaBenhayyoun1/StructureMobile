using System;
using System.Collections.Generic;
using StructureMobile.Models;
using StructureMobile.ViewModels;
using Xamarin.Forms;

namespace StructureMobile.Views
{
    public partial class ProductDetailsPage : ContentPage
    {
        ViewModelDetailsPage ViewModel;

        public ProductDetailsPage()
        {
            InitializeComponent();
        }

        public ProductDetailsPage(Product product) 
        {
            InitializeComponent();

            ViewModel = Resources["vm"] as ViewModelDetailsPage;
            ViewModel.Product = product;

        }

    }
}
