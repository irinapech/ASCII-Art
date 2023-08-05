using System;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ASCII_Art
{
    public class MonochromaticASCII : Parent
    {
        private string[] charactersChoice = { "$", "@", "B", "%", "8", "&", "W", "M", "#", "*", "o", "a", "h", "k", "b", "d", "p", "q", "w", "m", "Z", "O", "0", "Q", "L", "C", "J", "U", "Y", "X", "z", "c", "v", "u", "n", "x", "r", "j", "f", "t", "/", "|", "(", ")", "1", "{", "}", "[", "]", "?", "-", "_", "+", "~", "<", ">", "i", "!", "l", "I", ";", ":", ",", "^", "`", "'", "."} ;
        public MonochromaticASCII()
        {
            InitializeComponent();
        }

        ~MonochromaticASCII()
        {
        }

        internal string ConvertToMonochromaticAscii(Bitmap image, string mode)
        {
            StringBuilder imageText = new StringBuilder();

            int height = image.Height;
            int width = image.Width;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixel = image.GetPixel(j, i);
                    int colorValue = 0;
                    switch (mode)
                    {
                        case "Lightness":
                            colorValue = (Math.Max(Math.Max(pixel.R, pixel.G), pixel.B) + Math.Min(Math.Min(pixel.R, pixel.G), pixel.B)) / 2;
                            break;
                        case "Average":
                            colorValue = (pixel.R + pixel.G + pixel.B) / 3;
                            break;
                        case "Luminosity":
                            colorValue = (int)(0.21 * pixel.R + 0.72 * pixel.G + 0.07 * pixel.B);
                            break;

                    }
                    // calculating the gray factor of the pixel
                    Color gray = Color.FromArgb(colorValue, colorValue, colorValue);

                    if (i % 2 == 0)
                    {
                        int indexofASCIICharacter = (gray.R * 10) / 255;
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
