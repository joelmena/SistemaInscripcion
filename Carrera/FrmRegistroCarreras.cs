using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcion.Carrera
{
    public partial class FrmRegistroCarreras : Form
    {
        private INF518.Clases.Carrera carrera;

        public FrmRegistroCarreras(int id = 0)
        {
            InitializeComponent();
            carrera = new INF518.Clases.Carrera();

            if(id != 0)
            {
                carrera.ID = id;
                carrera = carrera.Detalle();
                ActualizarFormulario();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CargarCarrera();
            if(carrera.ID == 0)
            {
                if(carrera.Registrar())
                {
                    MessageBox.Show("Registro exitoso");
                }
                else
                {
                    MessageBox.Show("Error al registrar los datos");
                }
            }
            else
            {
                if (carrera.Actualizar())
                {
                    MessageBox.Show("Actualizacion exitosa");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar los datos");
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
            txtNombre.Text = string.Empty;
            numCreditos.Value = 0;
            txtObservaciones.Text = string.Empty;
        }

        private void ActualizarFormulario()
        {
            lbID.Text = carrera.ID.ToString();
            txtNombre.Text = carrera.Descripcion;
            numCreditos.Value = carrera.Creditos;
            txtObservaciones.Text = carrera.Observaciones;
        }

        private void CargarCarrera()
        {
            carrera.Descripcion = txtNombre.Text;
            carrera.Creditos = (int) numCreditos.Value;
            carrera.Observaciones = txtObservaciones.Text;
        }
        #endregion
    }
}
