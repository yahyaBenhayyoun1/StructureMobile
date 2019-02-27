using System;
using StructureMobile.Utils;
using StructureMobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace StructureMobile
{
    public partial class App : Application
    {
        public static string DatabasePath;

        public App(string databasePath)
        {
            InitializeComponent();
            DatabasePath = databasePath;


            if (Settings.AccesToken == "")
            {
                MainPage = new NavigationPage(new PageLogIn());
                return;
            }


            MainPage = new NavigationPage (new MainPage());

        }

       

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
