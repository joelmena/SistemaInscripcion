using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcion.Aula
{
    public partial class FrmConsultaAulas : Form
    {
        private INF518.Clases.Aula aula;
        public FrmConsultaAulas()
        {
            InitializeComponent();
            aula = new INF518.Clases.Aula();

            dgAulas.AutoGenerateColumns = false;
            ActualizarGridView();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ActualizarGridView(txtFiltro.Text);
            txtFiltro.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmRegistroAulas frm = new FrmRegistroAulas();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
            frm.Dispose();
            ActualizarGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            aula.ID = (int)dgAulas.SelectedRows[0].Cells["colID"].Value;
            FrmRegistroAulas frm = new FrmRegistroAulas(aula.ID);
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
            frm.Dispose();
            ActualizarGridView();
        }


        #region METODOS/FUNCIONES3
        private void ActualizarGridView(string filtro = "")
        {
            dgAulas.DataSource = aula.Aulas(filtro);
            lbTotal.Text = dgAulas.RowCount.ToString();
        }
        #endregion
    }
}
