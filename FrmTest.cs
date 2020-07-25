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
using SistemaInscripcion.Estudiante;

namespace SistemaInscripcion
{
    public partial class FrmTest : Form
    {
        private INF518.Clases.Estudiante est;
        public FrmTest()
        {
            InitializeComponent();
            est = new INF518.Clases.Estudiante();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            est.ID = Convert.ToInt32(txtEstudianteId.Text);
            est = est.Detalle();

            FrmRegistroEstudiantes frm = new FrmRegistroEstudiantes(1, est.ID);
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }
    }
}
