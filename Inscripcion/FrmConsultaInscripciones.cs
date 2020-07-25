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
        public FrmConsultaInscripciones()
        {
            InitializeComponent();
            est = new INF518.Clases.Estudiante();
            ins = new INF518.Clases.Inscripcion();

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

        #region METODOS/FUNCIONES
        private void CargarListBox()
        {
            lbxEstudiantes.DataSource = est.Estudiantes();
            lbxEstudiantes.ValueMember = "ID";
            lbxEstudiantes.DisplayMember = "Nombre";
        }

        private void ActualizarGridView()
        {
            dgInscripciones.DataSource = ins.Inscripciones();
        }
        #endregion

        private void lbxEstudiantes_Click(object sender, EventArgs e)
        {
            ins.IdEstudiante = (int)lbxEstudiantes.SelectedValue;
            ActualizarGridView();
        }
    }
}
