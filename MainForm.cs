using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using SistemaInscripcion.Estudiante;
using SistemaInscripcion.Profesor;
using SistemaInscripcion.Seccion;
using SistemaInscripcion.Centro;
using SistemaInscripcion.Asignatura;
using SistemaInscripcion.Aula;
using SistemaInscripcion.Carrera;
using SistemaInscripcion.Inscripcion;
using SistemaInscripcion.Usuario;
using SistemaInscripcion.Caja;

namespace SistemaInscripcion
{
    public partial class MainForm : Form
    {
        private int userId;
        private INF518.Clases.Usuario user;
        public MainForm(INF518.Clases.Usuario user)
        {
            InitializeComponent();
            this.user = user;
            lbNombreUsuario.Text = user.Nombre;
            //lbUsuarioId.Text = user.ID.ToString();
        }

        private void estudiantantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaEstudiantes frm = new FrmConsultaEstudiantes(user.ID);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;
            frm.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaProfesores frm = new FrmConsultaProfesores(user.ID);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;
            frm.Show();
        }

        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarSecciones frm = new FrmConsultarSecciones();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;

            frm.Show();
        }

        private void centrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaCentros frm = new FrmConsultaCentros();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;

            frm.Show();
        }

        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaAsignatura frm = new FrmConsultaAsignatura();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;

            frm.Show();
        }

        private void aulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaAulas frm = new FrmConsultaAulas();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;

            frm.Show();
        }

        private void carerrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaCarreras frm = new FrmConsultaCarreras();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;

            frm.Show();
        }

        private void inscriocionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaInscripciones frm = new FrmConsultaInscripciones();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;

            frm.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroUsuarios frm = new FrmRegistroUsuarios();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;

            frm.Show();
        }

        private void cobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCaja frm = new FrmCaja(user);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;

            frm.Show();
        }
    }
}
