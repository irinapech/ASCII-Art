using System;
using System.Drawing;
using System.Runtime.Remoting.Contexts;

namespace ASCII_Art
{
    public class AsciiMonochromaticConversion
    {
        private void btnConvertToAscii_CLick(object sender, EventArgs e)
        {
            btnConvertToAscii.Enabled = false;
            Bitmap image = new Bitmap(txtPath.text, true);
            image = GetResizedImage(image, this.trackBar.Value);
            _Content = ConvertToAscii(image);
            browsermain.DocumentText = "<pre>" + _Content + "</pre>";
            btnConvertToAscii.Enabled = false;
        }

        private Bitmap GetResizedIMage(Bitmap inputBitmap, int asciiWidth)
        {
            int asciiHeight = 0;
            asciiHeight = (int)Math.Ceiling((double)inputBitmap.Height * asciiWidth / inputBitmap.Width);
            Bitmap result = new Bitmap(asciiWidth, asciiHeight);
            Graphics g = Graphics.FromImage((Image)result);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(inputBitmap, 0, 0, asciiWidth, asciiHeight);
            g.Dispose();
            return result;
        }
    }
}
