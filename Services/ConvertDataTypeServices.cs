using System.Drawing;
using System.IO;

namespace JobNear.Services
{
    public class ConvertDataTypeServices
    {
        public static byte[] ConvertImageToBytes(Image img)
        {
            if (img == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                // Clone image into a safe bitmap to avoid GDI+ lock issues
                using (Bitmap bmp = new Bitmap(img))
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // always safe
                }
                return ms.ToArray();
            }
        }

        public static Image ConvertBytesToImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;

            using (MemoryStream ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
