using System;
using System.Drawing;
using System.IO;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace ASCII_Art
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
        }

        protected string Content { get; set; }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "Images (*.JPG;*.PNG)|*.JPG;*.PNG|" + "All files (*.*)|*.*";

            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Select Photos";

            DialogResult dr = this.openFileDialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textPath.Text = openFileDialog.FileName;
            }
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
                    Content = Content.Replace("nbsp;", " ");
                }
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                sw.Write(Content);
                sw.Flush();
                sw.Close();
            }
        }

        private Bitmap ChangeImageSize(Bitmap image, int ASCIIWidth)
        {
            int ASCIIeight = 0;
            ASCIIeight = (int)Math.Ceiling((double)image.Height * ASCIIWidth / image.Width);
            Bitmap resizedImage = new Bitmap(ASCIIWidth, ASCIIeight);
            Graphics g = Graphics.FromImage((Image)resizedImage);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(image, 0, 0, ASCIIWidth, ASCIIeight);
            g.Dispose();
            return resizedImage;
        }

        private void btnConvertToASCII_Click(object sender, EventArgs e)
        {
            MonochromaticASCII monochromaticASCII = new MonochromaticASCII();

            btnConvertToASCII.Enabled = false;
            Bitmap image = new Bitmap(textPath.Text, true);
            image = ChangeImageSize(image, image.Width);
            Content = monochromaticASCII.ConvertToMonochromaticAscii(image, "Average");
            browser.DocumentText = "<pre>" + Content + "</pre>";
            btnConvertToASCII.Enabled = true;
        }

        private void BtnConvertToNumbersASCII_Click(object sender, EventArgs e)
        {
            NumbersASCII numbersASCII = new NumbersASCII();

            btnConvertToNumbersASCII.Enabled = false;
            Bitmap image = new Bitmap(textPath.Text, true);
            Content = numbersASCII.ConvertToNumbersASCII(image).ToString();
            browser.DocumentText = Content;
            btnConvertToNumbersASCII.Enabled = true;
        }

        private void BtnChangeLightness_Click(object sender, EventArgs e)
        {
            MonochromaticASCII monochromaticASCII = new MonochromaticASCII();

            btnChangeLightness.Enabled = false;
            Bitmap image = new Bitmap(textPath.Text, true);
            image = ChangeImageSize(image, image.Width);
            Content = monochromaticASCII.ConvertToMonochromaticAscii(image, "Lightness");
            browser.DocumentText = Content;
            btnChangeLightness.Enabled = true;
        }

        private void BtnChangeLuminosity_Click(object sender, EventArgs e)
        {
            MonochromaticASCII monochromaticASCII = new MonochromaticASCII();

            btnChangeLuminosity.Enabled = false;
            Bitmap image = new Bitmap(textPath.Text, true);
            image = ChangeImageSize(image, image.Width);
            Content = monochromaticASCII.ConvertToMonochromaticAscii(image, "Luminosity");
            browser.DocumentText = Content;
            btnChangeLuminosity.Enabled = true;
        }

        private void BtnChangeBrowserBackgroundColor_Click(object sender, EventArgs e)
        {
            btnChangeBrowserBackgroundColor.Enabled = false;
            DialogResult colors = colorDialog.ShowDialog();
            if (colors == DialogResult.OK)
            {
                string colorCode = ColorTranslator.ToHtml(colorDialog.Color).ToString();
                browser.DocumentText += "<html><body style='background-color:" + colorCode + "'></body></html>";
            }
            btnChangeBrowserBackgroundColor.Enabled = true;
        }

        private void BtnChangeBrowserTextColor_Click(object sender, EventArgs e)
        {
            btnChangeBrowserTextColor.Enabled = false;
            DialogResult colors = colorDialog.ShowDialog();
            if (colors == DialogResult.OK)
            {
                string colorCode = ColorTranslator.ToHtml(colorDialog.Color).ToString();
                browser.DocumentText += "<html><body style='color:" + colorCode + "'></body></html>";
            }
            btnChangeBrowserTextColor.Enabled = true;
        }

        private void BtnInvertBrightness_Click(object sender, EventArgs e)
        {
            btnInvertBrightness.Enabled = false;
            Britghness britghness = new Britghness();

            Bitmap image = new Bitmap(textPath.Text, true);
            image = ChangeImageSize(image, image.Width);
            Content = britghness.RevertBrightness(image);
            browser.DocumentText = Content;
            btnInvertBrightness.Enabled = true;
        }
    }
}