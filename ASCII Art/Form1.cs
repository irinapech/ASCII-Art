using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ASCII_Art
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
        }
        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            browser.DocumentText = "";
            DialogResult diag = openFileDialog.ShowDialog();
            if (diag == DialogResult.OK)
            {
                textPath.Text = openFileDialog.FileName;
            }
        }

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

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FilterIndex == 1)
                {
                    content = content.Replace("nbsp;", " ").Replace("<br>", "\r\n");
                }
                else
                {
                    content = "<pre>" + content + "</pre>";
                }
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                sw.Write(content);
                sw.Flush();
                sw.Close();
            }
        }
    }
}