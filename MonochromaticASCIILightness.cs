using System;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ASCII_Art
{
    public class MonochromaticASCIILightness : Parent
    {
        private string[] charactersChoice = { "$", "@", "B", "%", "8", "&", "W", "M", "#", "*", "o", "a", "h", "k", "b", "d", "p", "q", "w", "m", "Z", "O", "0", "Q", "L", "C", "J", "U", "Y", "X", "z", "c", "v", "u", "n", "x", "r", "j", "f", "t", "/", "|", "(", ")", "1", "{", "}", "[", "]", "?", "-", "_", "+", "~", "<", ">", "i", "!", "l", "I", ";", ":", ",", "^", "`", "'", "." };
        public MonochromaticASCIILightness()
        {
            InitializeComponent();
        }

        ~MonochromaticASCIILightness()
        {
        }

        internal string ConvertToMonochromaticAsciiLightness(Bitmap image)
        {
            StringBuilder imageText = new StringBuilder();

            int height = image.Height;
            int width = image.Width;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixel = image.GetPixel(j, i);
                    int lightness = (Math.Max(Math.Max(pixel.R, pixel.G), pixel.B) + Math.Min(Math.Min(pixel.R, pixel.G), pixel.B)) / 2;
                    // calculating the gray factor of the pixel
                    Color grayBasedOnLightness = Color.FromArgb(lightness, lightness, lightness);

                    if (i % 2 == 0)
                    {
                        int indexofASCIICharacter = (grayBasedOnLightness.R * 10) / 255;
                        imageText.Append(charactersChoice[indexofASCIICharacter]);
                    }
                }

                if (i % 2 == 0)
                {
                    imageText.Append("\r\n");
                }
            }
            return imageText.ToString();
        }
    }
}
