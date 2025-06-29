using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Principal;
using static System.Net.Mime.MediaTypeNames.Image;

namespace FileWriter
{
    public class AppConfigImageFinder : BaseFileWriter
    {
        private Image _image;
        public AppConfigImageFinder():base()
        {
            _image = Image.FromFile(ConfigurationManager.AppSettings["ImagePath"]);
            _path = ConfigurationManager.AppSettings["FilePath"];
            base.WriteLine($"{_image.Height}X{_image.Width}");
        }
    }
}
