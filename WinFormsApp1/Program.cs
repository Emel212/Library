using Library.DataAccess;
using Library.DataAccess.Abstract;
using Library.DataAccess.Concrete;
using Library.Entities.Models;
using LibraryManagerWinForm;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
       
      

        
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
              
                Application.Run(new Main());

            //  app.UseMiddleware<GlobalErrorHandlingMiddleware>();


        }
    }
}
