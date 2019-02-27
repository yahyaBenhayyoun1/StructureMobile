using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using StructureMobile.ViewModels;

namespace StructureMobile.Views
{
    public partial class MainPage : ContentPage
    {
        ViewModelMainPage viewModel;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel = Resources["vm"] as ViewModelMainPage;
            viewModel.GetProduct();
             
        }
    }
}
