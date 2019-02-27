using System;
using System.Collections.Generic;
using System.IO;
using StructureMobile.Interface;
using Xamarin.Forms;

namespace StructureMobile.Views
{
    public partial class PhotoPicker : ContentPage
    {
        public PhotoPicker()
        {
            InitializeComponent();
        }

       async void Handle_Clicked(object sender, System.EventArgs e)
        {
            pickPictureButton.IsEnabled = false;
            Stream stream = await DependencyService.Get<IPicturePicker>().GetImageStreamAsync();

            if (stream != null)
            {
                /*Image image = new Image
                {
                    Source = ImageSource.FromStream(() => stream),
                    BackgroundColor = Color.Gray
                };

                //Stack.Children.Add(image);*/


                MyImage.Source = ImageSource.FromStream(() => stream);


                pickPictureButton.IsEnabled = true;
            }
            else
            {
                pickPictureButton.IsEnabled = true;
            }
        }
    }
}
