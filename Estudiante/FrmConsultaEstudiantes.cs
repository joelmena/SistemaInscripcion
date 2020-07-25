using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INF518.Clases;

namespace SistemaInscripcion.Estudiante
{
    public partial class FrmConsultaEstudiantes : Form
    {
        private int userId;
        private INF518.Clases.Estudiante est;
        public FrmConsultaEstudiantes(int userId)
        {
            InitializeComponent();
            est = new INF518.Clases.Estudiante();
            this.userId = userId;
            dgEstudiantes.AutoGenerateColumns = false;
            ActualizarGridView();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmRegistroEstudiantes frm = new FrmRegistroEstudiantes(userId);
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
            frm.Dispose();
            ActualizarGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            est.ID = (int) dgEstudiantes.SelectedRows[0].Cells["colID"].Value;

            FrmRegistroEstudiantes frm = new FrmRegistroEstudiantes(userId, est.ID);
            frm.StartPosition = FormStartPosition.CenterScreen;
            
            if(frm.ShowDialog() == DialogResult.OK)
            {
                ActualizarGridView();
            }
        }




        #region METODOS/FUNCIONES
        private void ActualizarGridView(string filtro = "")
        {
            dgEstudiantes.DataSource = est.Estudiantes(filtro);
            txtTotal.Text = dgEstudiantes.RowCount.ToString();
        }
        #endregion

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            var filtro = txtFiltro.Text;
            ActualizarGridView(filtro);
        }
    }
}
