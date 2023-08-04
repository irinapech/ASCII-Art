﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_Art
{
    public class MonochromaticASCII : Form
    {
        private readonly string[] charactersChoice = { "#", "#", "@", "@", "$", "$", "&", "&", "=", "=", "+", "+", "*", "*", ":", ":", "-", "-", ".", ".", "nbsp;" };
        private string content;

        private StringBuilder ConvertToAscii(Bitmap image)
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
                        imageText.Append(charactersChoice[indexofASCIICharacter]);
                    }
                }

                if (i % 2 == 0)
                {
                    imageText.Append("<br>");
                }
            }
            return imageText;
        }
        private void BtnConvertToASCII_Click(object sender, EventArgs e)
        {
            btnConvertToASCII.Enabled = false;
            Bitmap image = new Bitmap(textPath.Text, true);
            content = ConvertToAscii(image).ToString();
            browser.DocumentText = "<pre>" + content + "</pre>";
            btnConvertToASCII.Enabled = true;
        }
    }
}
