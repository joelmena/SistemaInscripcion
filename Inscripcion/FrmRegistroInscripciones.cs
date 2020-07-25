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
    public partial class FrmRegistroInscripciones : Form
    {
        INF518.Clases.Seccion seccion;
        INF518.Clases.Estudiante est;
        INF518.Clases.Inscripcion ins;
        public FrmRegistroInscripciones(int id = 0)
        {
            InitializeComponent();
            seccion = new INF518.Clases.Seccion();
            est = new INF518.Clases.Estudiante();
            ins = new INF518.Clases.Inscripcion();
            ActualizarGridView();

            if(id != 0)
            {
                est.ID = id;
                est = est.Detalle();
                ActualizarFormulario();
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            int idSeccion = (int)dgSeccion.SelectedRows[0].Cells["colSeccion"].Value;
            ins.IdEstudiante = est.ID;
            if(ins.Registrar(idSeccion))
            {
                MessageBox.Show("Asignatura inscripta con exito");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al intentar inscribir la Asignatura");
            }
        }


        #region
        private void ActualizarGridView()
        {
            dgSeccion.DataSource = ins.Secciones();
        }

        private void ActualizarFormulario()
        {
            lbMatricula.Text = est.Matricula.ToString();
            lbNombres.Text = est.Nombre;
            lbApellidos.Text = est.Apellidos;
            lbSexo.Text = est.Sexo.ToString();
            
        }
        #endregion

    }
}
