using System;
using System.IO;
using System.Threading.Tasks;

namespace StructureMobile.Interface
{
    public interface IPicturePicker
    {

        Task<Stream> GetImageStreamAsync();

    }
}
