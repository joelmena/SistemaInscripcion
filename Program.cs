using SistemaInscripcion.Reporte;
using SistemaInscripcion.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin frm = new FrmLogin();

            Application.Run(frm);

            if(frm.DialogResult == DialogResult.OK)
            {
                Application.Run(new MainForm(frm.user));
            }
            frm.Dispose();
        }
    }
}
