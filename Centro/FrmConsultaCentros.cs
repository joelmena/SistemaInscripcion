using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcion.Centro
{
    public partial class FrmConsultaCentros : Form
    {
        INF518.Clases.Centro centro;
        public FrmConsultaCentros()
        {
            InitializeComponent();
            centro = new INF518.Clases.Centro();
            dgCentros.AutoGenerateColumns = false;
            ActualizarGridView();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmRegistroCentros frm = new FrmRegistroCentros();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
            frm.Dispose();
            ActualizarGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            centro.ID = (int) dgCentros.SelectedRows[0].Cells["colID"].Value;

            FrmRegistroCentros frm = new FrmRegistroCentros(centro.ID);
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
            frm.Dispose();
            ActualizarGridView();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGridView(txtFiltro.Text);
            txtFiltro.Text = string.Empty;
        }



        #region METODOS/FUNCIONES
        private void ActualizarGridView(string filtro = "")
        {
            dgCentros.DataSource = centro.Centros(filtro);
            lbTotal.Text = dgCentros.RowCount.ToString();
        }
        #endregion

    }
}
