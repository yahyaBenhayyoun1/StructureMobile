using System;
using StructureMobile;
using StructureMobile.iOS.CustomRenderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyButton), typeof(MyButtonRenderers))]
namespace StructureMobile.iOS.CustomRenderer
{
    public class MyButtonRenderers : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);

            }
        }
    }
}
