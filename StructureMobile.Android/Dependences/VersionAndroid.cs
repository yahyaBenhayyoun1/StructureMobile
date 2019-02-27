using System;
using Android.OS;
using StructureMobile.Droid.Dependences;
using StructureMobile.Interface;
using Xamarin.Forms;

[assembly: Dependency(typeof(VersionAndroid))]
namespace StructureMobile.Droid.Dependences
{
    public class VersionAndroid : IPlatform
    {
        public VersionAndroid()
        {
        }
        public string GetVersion()
        {
            return Build.VERSION.Release;
        }

        public string Hello()
        {
            return "Hello from Android";
        }
    }
}
