using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcion.Asignatura
{
    public partial class FrmRegistroAsignaturas : Form
    {
        INF518.Clases.Asignatura asignatura;
        public FrmRegistroAsignaturas(int id = 0)
        {
            InitializeComponent();
            asignatura = new INF518.Clases.Asignatura();

            CargarComboBox();

            if(id > 0)
            {
                asignatura.ID = id;
                asignatura =  asignatura.Detalle();
                ActualizarFormulario();
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CargarAsignatura();
            if(asignatura.ID == 0)
            {
                if(asignatura.Registrar())
                {
                    MessageBox.Show("Registro exitoso");
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Error al intentar registrar los datos");
                }
            }
            else
            {
                if (asignatura.Actualizar())
                {
                    MessageBox.Show("Actualizacion exitosa");
                    this.Close();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Error al intentar actualizar los datos");
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region METODOS/FUNCIONES
        private void LimpiarFormulario()
        {
            lbID.Text = "NUEVO";
            cbCarrera.ResetText();
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            numCreditos.Value = 0;
            txtObservaciones.Text = string.Empty;
        }

        private void CargarAsignatura()
        {
            asignatura.IdCarrera = (int) cbCarrera.SelectedValue;
            asignatura.Codigo = txtCodigo.Text;
            asignatura.Descripcion = txtNombre.Text;
            asignatura.Creditos = (int) numCreditos.Value;
            asignatura.Observaciones = txtObservaciones.Text;
        }

        private void ActualizarFormulario()
        {
            lbID.Text = asignatura.ID.ToString();
            cbCarrera.SelectedValue = asignatura.IdCarrera;
            txtCodigo.Text = asignatura.Codigo;
            txtNombre.Text = asignatura.Descripcion;
            numCreditos.Value = asignatura.Creditos;
            txtObservaciones.Text = asignatura.Observaciones;
        }

        private void CargarComboBox()
        {
            INF518.Clases.Carrera carreras = new INF518.Clases.Carrera();
            cbCarrera.DataSource = carreras.Carreras();
            cbCarrera.ValueMember = "ID";
            cbCarrera.DisplayMember = "Descripcion";
        }

        private void ValidarFormulario()
        {

        }
        #endregion

    }
}
