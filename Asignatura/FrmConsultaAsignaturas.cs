using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcion.Asignatura
{
    public partial class FrmConsultaAsignatura : Form
    {
        INF518.Clases.Asignatura asignatura;
        public FrmConsultaAsignatura()
        {
            InitializeComponent();
            asignatura = new INF518.Clases.Asignatura();
            dgAsignaturas.AutoGenerateColumns = false;
            ActualizarGridView();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ActualizarGridView(txtFiltro.Text);
            txtFiltro.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmRegistroAsignaturas frm = new FrmRegistroAsignaturas();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
            ActualizarGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            asignatura.ID = (int)dgAsignaturas.SelectedRows[0].Cells["colID"].Value;
            FrmRegistroAsignaturas frm = new FrmRegistroAsignaturas(asignatura.ID);
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
            ActualizarGridView();
        }



        #region METODOS/FUNCIONES
        private void ActualizarGridView(string filtro = "")
        {
            dgAsignaturas.DataSource = asignatura.Asignaturas(filtro);
            lbTotal.Text = dgAsignaturas.RowCount.ToString();
        }
        #endregion

    }
}
