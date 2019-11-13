using System;
using System.IO;
using System.Threading.Tasks;

namespace ImagePicker2.Services
{
    public interface IPhotoPickerService
    {
        Task<Stream> GetImageStreamAsync();
    }
}
