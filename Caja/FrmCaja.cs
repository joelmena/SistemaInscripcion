using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcion.Caja
{
    public partial class FrmCaja : Form
    {
        //INF518.Clases.Usuario user;
        INF518.Clases.Cobro cobro;
        private DataTable dt;
        public FrmCaja(INF518.Clases.Usuario user)
        {
            InitializeComponent();
            user = new INF518.Clases.Usuario();
            cobro = new INF518.Clases.Cobro();
            dt = new DataTable();

            dgInscripciones.AutoGenerateColumns = false;
            ActualizarDataGridView();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ActualizarDataGridView(txtFiltro.Text);
            Limpiar();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            cobro.Monto = Convert.ToDecimal(txtMonto.Text);
            decimal devuelta = cobro.Cobrar();
            decimal balance = Convert.ToDecimal(lbBalance.Text);

            var est = new INF518.Clases.Estudiante
            {
                ID = cobro.IdEstudiante,
                Matricula = Convert.ToInt32(lbMatricula.Text),
                Nombre = lbNombre.Text,
                Balance = Convert.ToDecimal(lbBalance.Text),
            };

            FrmCobro frm = new FrmCobro(balance, cobro.Monto, est);
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (devuelta >= 0)
            {
                frm.ShowDialog();
                frm.Dispose();
                Limpiar();
                ActualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Error", "Cobro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(devuelta.ToString(), "Cobro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        #region
        private void ActualizarDataGridView(string filtro = "")
        {
            //this.dt = 
            dgInscripciones.DataSource = cobro.Cuentas(filtro);
            lbTotal.Text = Convert.ToInt32(dgInscripciones.RowCount).ToString();
        }

        private void Limpiar()
        {
            txtFiltro.Text = string.Empty;

            lbMatricula.Text = string.Empty;
            lbNombre.Text = string.Empty;
            lbBalance.Text = string.Empty;
            txtMonto.Text = string.Empty;
        }

        private void ActualizarFormulario()
        {
            cobro.IdEstudiante = (int)dgInscripciones.SelectedRows[0].Cells["colIdEstudiante"].Value;
            cobro.IdInscripcion = (int)dgInscripciones.SelectedRows[0].Cells["colIdInscripcion"].Value;
            lbMatricula.Text = dgInscripciones.SelectedRows[0].Cells["colMatricula"].Value.ToString();
            lbNombre.Text = dgInscripciones.SelectedRows[0].Cells["colNombre"].Value.ToString();
            lbBalance.Text = dgInscripciones.SelectedRows[0].Cells["colBalance"].Value.ToString();
        }
        #endregion

        private void dgInscripciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarFormulario();
        }
    }
}
