using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team5_SmartMOM
{
    public class ImageConverterHelper
    {
        public static byte[] ImageToByte(Image img)
        {
            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static byte[] imageTobyteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
