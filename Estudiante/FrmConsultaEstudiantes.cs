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
using Microsoft.Reporting.WinForms;
using SistemaInscripcion.Reporte;

namespace SistemaInscripcion.Estudiante
{
    public partial class FrmConsultaEstudiantes : Form
    {
        private int userId;
        private INF518.Clases.Estudiante est;
        private DataTable dt;
        public FrmConsultaEstudiantes(int userId)
        {
            InitializeComponent();
            est = new INF518.Clases.Estudiante();
            dt = new DataTable();
            dgEstudiantes.AutoGenerateColumns = false;

            this.userId = userId;
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

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            var filtro = txtFiltro.Text;
            ActualizarGridView(filtro);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes();
            ReportParameter[] parametros = new ReportParameter[4];

            parametros[0] = new ReportParameter("CompanyName", "Universidad Autonoma de Santo Domingo");
            parametros[1] = new ReportParameter("Address", "Ave. Manolo Justo");
            parametros[2] = new ReportParameter("PhoneNumber", "809-588-1414");
            parametros[3] = new ReportParameter("Email", "uasd@email.com");

            frm.reportViewer.Reset();

            frm.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsEstudiantesPorCarrera", dt));
            frm.reportViewer.LocalReport.ReportEmbeddedResource = "SistemaInscripcion.Reporte.RptEstudiantes.rdlc";
            frm.reportViewer.LocalReport.SetParameters(parametros);

            frm.reportViewer.RefreshReport();
            frm.ShowDialog();

            frm.Dispose();
        }



        #region METODOS/FUNCIONES
        private void ActualizarGridView(string filtro = "")
        {
            dgEstudiantes.DataSource = est.Estudiantes(filtro);
            txtTotal.Text = dgEstudiantes.RowCount.ToString();
        }
        #endregion

    }
}
