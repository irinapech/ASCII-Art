using System;
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

        MonochromaticASCII monochromaticASCII = new MonochromaticASCII();

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
                    monochromaticASCII.content = monochromaticASCII.content.Replace("nbsp;", " ").Replace("<br>", "\r\n");
                }
                else
                {
                    monochromaticASCII.content = "<pre>" + monochromaticASCII.content + "</pre>";
                }
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                sw.Write(monochromaticASCII.content);
                sw.Flush();
                sw.Close();
            }
        }
    }
}