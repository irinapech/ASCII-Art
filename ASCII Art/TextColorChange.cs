using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASCII_Art
{
    public class TextColorChange : Parent
    {
        private string[] charactersChoice = { "$", "@", "B", "%", "8", "&", "W", "M", "#", "*", "o", "a", "h", "k", "b", "d", "p", "q", "w", "m", "Z", "O", "0", "Q", "L", "C", "J", "U", "Y", "X", "z", "c", "v", "u", "n", "x", "r", "j", "f", "t", "/", "|", "(", ")", "1", "{", "}", "[", "]", "?", "-", "_", "+", "~", "<", ">", "i", "!", "l", "I", ";", ":", ",", "^", "`", "'", "." };
        public TextColorChange()
        {
            InitializeComponent();
        }

        ~TextColorChange()
        {
        }

        internal StreamWriter ChangeTextColor(Bitmap image)
        {
            StreamWriter sw = new StreamWriter(Content);

            int height = image.Height;
            int width = image.Width;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Color pixel = image.GetPixel(j, i);
                    sw.Write("<font size= 1 face= Courier New color = " + ColorTranslator.ToHtml(Color.Aqua) + ">" + pixel + "</font>");
                    //int colorValue = (pixel.R + pixel.G + pixel.B) / 3;
                       
                    //// calculating the gray factor of the pixel
                    //Color gray = Color.FromArgb(colorValue, colorValue, colorValue);

                    //if (i % 2 == 0)
                    //{
                    //    int indexofASCIICharacter = (gray.R * 10) / 255;
                    //    sw.Write(Content);

                    //    imageText.Append(charactersChoice[indexofASCIICharacter]);
                    //}
                }

                //if (i % 2 == 0)
                //{
                //    imageText.Append("\r\n");
                //}
            }

            sw.Flush();
            sw.Close();

            return sw;
        }
    }
}
