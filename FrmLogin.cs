using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcion.Usuario
{
    public partial class FrmLogin : Form
    {
        public INF518.Clases.Usuario user;
        public FrmLogin()
        {
            InitializeComponent();
            user = new INF518.Clases.Usuario();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            user.NombreUsuario = txtUsuario.Text;
            user.Password = txtPassword.Text;

            if (user.EsValido() > 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
