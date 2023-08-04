using System;
using System.IO;
using System.Windows.Forms;

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

        //private string content;

        public string Content { get; set; }

        public void BtnBrowse_Click(object sender, EventArgs e)
        {
            browser.DocumentText = "";
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
    }
}