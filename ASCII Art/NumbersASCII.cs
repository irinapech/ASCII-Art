using System;
using System.Drawing;
using System.Text;

namespace ASCII_Art
{
    public class NumbersASCII : Parent
    {
        private string[] numbersChoice = { "2", "2", "3", "3", "1", "1", "5", "5", "7", "7", "6", "6", "9", "9", "4", "4", "8", "8", "0", "0", ".", ".", "nbsp;" } ;

        public NumbersASCII() 
        {
        }

        ~NumbersASCII() { }

        public StringBuilder ConvertToNumbersASCII(Bitmap image)
        {
            StringBuilder imageText = new StringBuilder();

            int height = image.Height;
            int width = image.Width;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixel = image.GetPixel(j, i);
                    int rgb = (pixel.R + pixel.G + pixel.B) / 3;
                    // calculating the gray factor of the pixel
                    Color gray = Color.FromArgb(rgb, rgb, rgb);

                    if (i % 2 == 0)
                    {
                        int indexofASCIICharacter = (gray.R * 10) / 255;
                        imageText.Append(numbersChoice[indexofASCIICharacter]);
                    }
                }

                if (i % 2 == 0)
                {
                    imageText.Append("<br>");
                }
            }
            return imageText;
        }
    }
}
