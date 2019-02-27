using System;

using Xamarin.Forms;

namespace StructureMobile.Interface
{
    public interface IPlatform 
    {
        string Hello();

        string GetVersion();
    }
}

