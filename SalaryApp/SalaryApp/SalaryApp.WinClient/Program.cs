using SalaryApp.Repositoris;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalaryApp.Repositoris.Entities;

namespace SalaryApp.WinClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            using (var unitOfWork = new UnitOfWork(new SalaryAppContext()))
            {
                var bank = unitOfWork.Banks.GetByTitle("بانک تجارت");

            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
           
        }
    }
}
