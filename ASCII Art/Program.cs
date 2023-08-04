using System;
using System.Windows.Forms;

namespace ASCII_Art
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(object sender, EventArgs e)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());

            MonochromaticASCII monochromaticASCII = new MonochromaticASCII();
            monochromaticASCII.BtnConvertToMonochromaticASCII_Click(sender, e);
            monochromaticASCII.BtnSaveAs_Click(sender, e);
            monochromaticASCII.BtnBrowse_Click(sender, e);

            NumbersASCII numbersASCII = new NumbersASCII();
            numbersASCII.BtnConvertToNumbersASCII_Click(sender, e);
            numbersASCII.BtnSaveAs_Click(sender, e);
            numbersASCII.BtnBrowse_Click(sender, e);
        }
    }
}
