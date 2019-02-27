using System;
using Xamarin.Essentials;
using System.Collections.Generic;

using Xamarin.Forms;

namespace StructureMobile.Views
{
    public partial class Geolocalisation : ContentPage
    {
        public Geolocalisation()
        {
            InitializeComponent();
        }

    

      async void Handle_Clicked(object sender, System.EventArgs e)
        {

            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                    LabelLongLat.Text = "Lat:" + location.Latitude + "Long" + location.Longitude;
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }
        }
    }
}
