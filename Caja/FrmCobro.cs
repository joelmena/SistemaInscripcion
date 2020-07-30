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

namespace SistemaInscripcion.Caja
{
    public partial class FrmCobro : Form
    {
        private INF518.Clases.Estudiante est;
        INF518.Clases.Cobro cobro;
        private DataTable dt;
        private decimal recibido;
        public FrmCobro(decimal balance, decimal recibido, INF518.Clases.Estudiante est)
        {
            InitializeComponent();
            cobro = new INF518.Clases.Cobro();
            this.recibido = recibido;
            this.est = est;

            lbRecibido.Text = recibido.ToString();
            lbDevuelta.Text = (recibido > balance) ? (recibido - balance).ToString() : "0.0000";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            INF518.Clases.Centro centro = new INF518.Clases.Centro();
            centro.ID = 1;
            var c = centro.Detalle();

            FrmReportes frm = new FrmReportes();
            ReportParameter[] parametros = new ReportParameter[7];
            parametros[0] = new ReportParameter("CompanyName", c.Descripcion);
            parametros[1] = new ReportParameter("NombreCorto", c.NombreCorto);
            parametros[2] = new ReportParameter("Telefono", c.Telefono);
            parametros[3] = new ReportParameter("WebSite", c.WebSite);
            parametros[4] = new ReportParameter("Matricula", est.Matricula.ToString());
            parametros[5] = new ReportParameter("Nombre", est.Nombre);
            parametros[6] = new ReportParameter("Recibido", this.recibido.ToString());

            frm.reportViewer.Reset();

            cobro.IdEstudiante = est.ID;
            dt = cobro.Factura();

            frm.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsFactura", dt));
            frm.reportViewer.LocalReport.ReportEmbeddedResource = "SistemaInscripcion.Reporte.RptFactura.rdlc";

            frm.reportViewer.LocalReport.SetParameters(parametros);

            frm.reportViewer.RefreshReport();
            frm.ShowDialog();
            frm.Dispose();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
