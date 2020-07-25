using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcion.Profesor
{
    public partial class FrmConsultaProfesores : Form
    {
        private int userId;
        private INF518.Clases.Profesor profe;
        public FrmConsultaProfesores(int userId)
        {
            InitializeComponent();
            profe = new INF518.Clases.Profesor();
            this.userId = userId;

            dgProfesores.AutoGenerateColumns = false;
            ActualizarGridView();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmRegistroProfesores frm = new FrmRegistroProfesores(userId);
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
            frm.Dispose();
            ActualizarGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            profe.ID = (int)dgProfesores.SelectedRows[0].Cells["colID"].Value;

            FrmRegistroProfesores frm = new FrmRegistroProfesores(userId, profe.ID);
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                ActualizarGridView();
            }
        }




        #region METODOS/FUNCIONES
        private void ActualizarGridView(string filtro = "")
        {
            dgProfesores.DataSource = profe.Profesores(filtro);
            txtTotal.Text = dgProfesores.RowCount.ToString();
        }
        #endregion

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            var filtro = txtFiltro.Text;
            ActualizarGridView(filtro);
            txtFiltro.Text = string.Empty;
        }

    }
}
