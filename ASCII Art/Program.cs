using System;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using ASCII_Art;

public class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new ASCII_Art.Form1());
    }
}

