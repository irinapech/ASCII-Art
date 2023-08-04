using System;
using System.Drawing;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace ASCII_Art
{
    public partial class Parent : System.Windows.Forms.Form
    {
        public Parent()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
        }

        public string Content { get; set; }

        public void BtnBrowse_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";
            DialogResult diag = openFileDialog.ShowDialog();
            if (diag == DialogResult.OK)
            {
                textPath.Text = openFileDialog.FileName;
            }
        }

        public void BtnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FilterIndex == 1)
                {
                    Content = Content.Replace("nbsp;", " ").Replace("<br>", "\r\n");
                }
                else
                {
                    Content = "<pre>" + Content + "</pre>";
                }
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                sw.Write(Content);
                sw.Flush();
                sw.Close();
            }
        }

        private Bitmap ChangeImageSize(Bitmap bitmap, int ASCIIWidth)
        {
            int ASCIIeight = 0;
            //Calculate the new Height of the image from its width
            ASCIIeight = (int)Math.Ceiling((double)bitmap.Height * ASCIIWidth / bitmap.Width);
            //Create a new Bitmap and define its resolution
            Bitmap result = new Bitmap(ASCIIWidth, ASCIIeight);
            Graphics g = Graphics.FromImage((Image)result);
            //The interpolation mode produces high quality images
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(bitmap, 0, 0, ASCIIWidth, ASCIIeight);
            g.Dispose();
            return result;
        }

        private void btnConvertToASCII_Click(object sender, EventArgs e)
        {
            MonochromaticASCII monochromaticASCII = new MonochromaticASCII();

            btnConvertToASCII.Enabled = false;
            Bitmap image = new Bitmap(textPath.Text, true);
            image = ChangeImageSize(image, image.Width);
            Content = monochromaticASCII.ConvertToMonochromaticAscii(image);
            richTextBox.Text += Environment.NewLine + Content;
            //richTextBox.Text = "<pre>" + Content + "</pre>";
            //richTextBox.DocumentText = "<pre>" + Content + "</pre>";
            btnConvertToASCII.Enabled = true;
        }

        public void BtnConvertToNumbersASCII_Click(object sender, EventArgs e)
        {
            NumbersASCII numbersASCII = new NumbersASCII();
            
            btnConvertToASCII.Enabled = false;
            Bitmap image = new Bitmap(textPath.Text, true);
            Content = numbersASCII.ConvertToNumbersASCII(image).ToString();
            richTextBox.Text = "<pre>" + Content + "</pre>";
            //richTextBox.DocumentText = "<pre>" + Content + "</pre>";
            btnConvertToASCII.Enabled = true;
        }

        private void textColorButton_Click(object sender, System.EventArgs e)
        {
            ColorDialog colorChooser = new ColorDialog();
            DialogResult result;

            result = colorChooser.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }

            richTextBox.ForeColor = colorChooser.Color;
            backgroundColorButton.ForeColor = colorChooser.Color;
            textColorButton.ForeColor = colorChooser.Color;

        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorChooser = new ColorDialog();
            DialogResult result;

            colorChooser.FullOpen = true;
            result = colorChooser.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }
            this.BackColor = colorChooser.Color;
            richTextBox.BackColor = colorChooser.Color;
            backgroundColorButton.BackColor = colorChooser.Color;
        }
    }
}