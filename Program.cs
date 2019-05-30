using ProjetoSebo.telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MySql.Data.EntityFramework;
using ProjetoSebo.dao;

namespace ProjetoSebo
{
    static class Program
    {
        private static SeboContext _context;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _context = new SeboContext();
            _context.Database.Initialize(true);

            Application.Run(new Login(_context));
        }
    }
}
