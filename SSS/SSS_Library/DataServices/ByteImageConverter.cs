using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS_Library.DataServices
{
    public class ByteImageConverter
    {
        public static byte[] ConvertImageToBytes(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public static byte[] ConvertImageToBytes(Image image, ImageFormat imageFormat)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, imageFormat);
            return ms.ToArray();
        }

        public static Image ConvertBytesToImage(byte[] imageByteArray)
        {
            MemoryStream ms = new MemoryStream(imageByteArray);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static Icon ConvertBytesToIcon(byte[] iconByteArray)
        {
            //does not work
            /*using (MemoryStream ms = new MemoryStream(iconByteArray))
            {
                return new Icon(ms);
            }*/

            Image img = ConvertBytesToImage(iconByteArray);
            Bitmap bitmap = new Bitmap(img);
            IntPtr hicon = bitmap.GetHicon();// Get an Hicon for myBitmap.
            Icon newIcon = Icon.FromHandle(hicon);// Create a new icon from the handle.
            return newIcon;
        }
    }
}
