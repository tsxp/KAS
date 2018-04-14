using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace KAS.KslAutosScraper
{
    public class KslImage
    {
        ImageSource img = null;
        string base64Img = null;

        public ImageSource Img { get => img; set => img = value; }
        public string Base64Img { get => base64Img; set => base64Img = value; }
    }
}
