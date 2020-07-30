using Microsoft.Reporting.WinForms;
using SistemaInscripcion.Reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcion.Inscripcion
{
    public partial class FrmConsultaInscripciones : Form
    {
        private INF518.Clases.Estudiante est;
        private INF518.Clases.Inscripcion ins;
        private DataTable dt;
        public FrmConsultaInscripciones()
        {
            InitializeComponent();
            est = new INF518.Clases.Estudiante();
            ins = new INF518.Clases.Inscripcion();
            dt = new DataTable();

            dgInscripciones.AutoGenerateColumns = false;
            CargarListBox();

            ins.IdEstudiante = 1;
            ActualizarGridView();
        }


        private void btnInscribir_Click(object sender, EventArgs e)
        {
            int id = (int)lbxEstudiantes.SelectedValue;
            FrmRegistroInscripciones frm = new FrmRegistroInscripciones(id);
            frm.StartPosition = FormStartPosition.CenterScreen;
            
            if(frm.ShowDialog() == DialogResult.OK)
            {
                CargarListBox();
                ActualizarGridView();
            }
            frm.Dispose();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            est.ID = (int)lbxEstudiantes.SelectedValue;
            est = est.Detalle();
            INF518.Clases.Centro centro = new INF518.Clases.Centro();
            centro.ID = 1;
            var centros = centro.Detalle();

            FrmReportes frm = new FrmReportes();
            ReportParameter[] parametros = new ReportParameter[6];

            parametros[0] = new ReportParameter("CompanyName", centro.Descripcion);
            parametros[1] = new ReportParameter("NombreCorto", centro.NombreCorto);
            parametros[2] = new ReportParameter("Telefono", centro.Telefono);
            parametros[3] = new ReportParameter("WebSite", centro.WebSite);

            parametros[4] = new ReportParameter("Matricula", est.Matricula.ToString());
            parametros[5] = new ReportParameter("Nombre", est.Nombre + " " + est.Apellidos);

            frm.reportViewer.Reset();

            frm.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsInscripciones", dt));
            frm.reportViewer.LocalReport.ReportEmbeddedResource = "SistemaInscripcion.Reporte.RptInscripciones.rdlc";
            frm.reportViewer.LocalReport.SetParameters(parametros);
            frm.reportViewer.RefreshReport();
            frm.ShowDialog();
            frm.Dispose();

        }

        private void lbxEstudiantes_Click(object sender, EventArgs e)
        {
            ins.IdEstudiante = (int)lbxEstudiantes.SelectedValue;
            ActualizarGridView();
        }


        #region METODOS/FUNCIONES
        private void CargarListBox()
        {
            lbxEstudiantes.DataSource = est.Estudiantes();
            lbxEstudiantes.ValueMember = "ID";
            lbxEstudiantes.DisplayMember = "Nombre";
        }

        private void ActualizarGridView()
        {
            this.dt = ins.Inscripciones();
            dgInscripciones.DataSource = dt;
        }
        #endregion


    }
}
