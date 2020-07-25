using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcion.Carrera
{
    public partial class FrmConsultaCarreras : Form
    {
        INF518.Clases.Carrera carrera;
        public FrmConsultaCarreras()
        {
            InitializeComponent();
            carrera = new INF518.Clases.Carrera();

            dgCarrera.AutoGenerateColumns = false;
            ActualizarGridView();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ActualizarGridView(txtFiltro.Text);
            txtFiltro.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmRegistroCarreras frm = new FrmRegistroCarreras();
            frm.StartPosition = FormStartPosition.CenterScreen;
            
            frm.ShowDialog();
            frm.Dispose();

            ActualizarGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            carrera.ID = (int)dgCarrera.SelectedRows[0].Cells["colID"].Value;
            FrmRegistroCarreras frm = new FrmRegistroCarreras(carrera.ID);
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
            frm.Dispose();

            ActualizarGridView();
        }


        #region METODOS/FUNCIONES3
        private void ActualizarGridView(string filtro = "")
        {
            dgCarrera.DataSource = carrera.Carreras(filtro);
            lbTotal.Text = dgCarrera.RowCount.ToString();
        }
        #endregion
    }
}
