using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcion.Seccion
{
    public partial class FrmConsultarSecciones : Form
    {
        INF518.Clases.Seccion seccion;
        public FrmConsultarSecciones()
        {
            InitializeComponent();
            seccion = new INF518.Clases.Seccion();

            dgSeccion.AutoGenerateColumns = false;
            ActualizarGridView();
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ActualizarGridView(txtFiltro.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCrearSecciones frm = new FrmCrearSecciones();
            frm.StartPosition = FormStartPosition.CenterScreen;

            if(frm.ShowDialog() == DialogResult.OK)
            {

            }
            frm.Dispose();
            ActualizarGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            seccion.ID = (int)dgSeccion.SelectedRows[0].Cells["colID"].Value;
            FrmCrearSecciones frm = new FrmCrearSecciones(seccion.ID);
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
            frm.Dispose();
            ActualizarGridView();
        }


        #region METODOS/FUNCIONES
        private void ActualizarGridView(string filtro = "")
        {
            dgSeccion.DataSource = seccion.Secciones(filtro);
            lbTotal.Text = dgSeccion.RowCount.ToString();
        }
        #endregion
    }
}
