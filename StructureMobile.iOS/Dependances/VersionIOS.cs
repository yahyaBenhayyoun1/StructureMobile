using System;
using StructureMobile.Interface;
using StructureMobile.iOS.Dependances;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(VersionIOS))]
namespace StructureMobile.iOS.Dependances
{
    public class VersionIOS : IPlatform
    {
        UIDevice device = new UIDevice();

        public VersionIOS()
        {
        }

        public string GetVersion()
        {
            return device.SystemVersion;
        }

        public string Hello()
        {
            return "Hello From IOS";
        }
    }
}
