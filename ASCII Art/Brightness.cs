using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Art
{
    public class Britghness : Parent
    {
        private string[] charactersChoice = { "$", "@", "B", "%", "8", "&", "W", "M", "#", "*", "o", "a", "h", "k", "b", "d", "p", "q", "w", "m", "Z", "O", "0", "Q", "L", "C", "J", "U", "Y", "X", "z", "c", "v", "u", "n", "x", "r", "j", "f", "t", "/", "|", "(", ")", "1", "{", "}", "[", "]", "?", "-", "_", "+", "~", "<", ">", "i", "!", "l", "I", ";", ":", ",", "^", "`", "'", "." };
        public Britghness()
        {
            InitializeComponent();
        }

        ~Britghness()
        {
        }

        internal string RevertBrightness(Bitmap image)
        {
            StringBuilder imageText = new StringBuilder();

            int height = image.Height;
            int width = image.Width;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixel = image.GetPixel(j, i);
                    int colorValue = ((255 - pixel.R) + (255 - pixel.G) + (255 - pixel.B)) / 3;

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
