using System;
using System.Collections.Generic;
using StructureMobile.Interface;
using Xamarin.Forms;

namespace StructureMobile.Views
{
    public partial class DepServicePage : ContentPage
    {
        public DepServicePage()
        {
            InitializeComponent();
        }

        void depService_Clicked(object sender, System.EventArgs e)
        {
            var service = DependencyService.Get<IPlatform>();
            DisplayAlert("Dependency", service.GetVersion(), "Continue");

        }
    }
}
