using Org.BouncyCastle.Tls;
using SoftwareIIb.Exceptions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace SoftwareIIb
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            //var _config = new ConfigurationBuilder().Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //System.AppDomain.CurrentDomain.FirstChanceException += (object sender, FirstChanceExceptionEventArgs e) =>
            //{
            //    switch (e.Exception.ToString())
            //    {
            //        case "TabUnavailableException":
            //            MessageBox.Show(e.Exception.Message);
            //            break;
            //        default:
            //            ShowUnhandledException(e);
            //            break;
            //    }
            //};
                //UnhandledExceptionTrapper;
            Application.Run(new MainForm());
        }

        static void ShowUnhandledException(FirstChanceExceptionEventArgs e)
        {

            //string errorMessage = string.Format("An application error occurred.\nPlease check whether your data is correct and repeat the action. If this error occurs again there seems to be a more serious malfunction in the application, and you better close it.\n\nError: {0}\n\nDo you want to continue?\n(if you click Yes you will continue with your work, if you click No the application will close)");
            string errorMessage = string.Format("An unhandled exception occurred: {0}", e.Exception.Message);

            //e.ExceptionObject.Message + (e.Exception.InnerException != null ? "\n" +
            //e.InnerException.Message : null));

            //if (MessageBox.Show(errorMessage, "Application Error", MessageBoxButton.YesNoCancel, MessageBoxImage.Error) == MessageBoxResult.No)
            //{
            //    if (MessageBox.Show("WARNING: The application will close. Any changes will not be saved!\nDo you really want to close it?", "Close the application!", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            //    {
            //        Application.Current.Shutdown();
            //    }
            //}
        }
    }
}