using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaInscripcion.Aula
{
    public partial class FrmRegistroAulas : Form
    {
        private INF518.Clases.Aula aula;
        public FrmRegistroAulas(int id = 0)
        {
            InitializeComponent();
            aula = new INF518.Clases.Aula();

            CargarComboBox();

            if (id != 0)
            {
                aula.ID = id;
                aula = aula.Detalle();
                ActualizarFormulario();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CargarAula();

            if(aula.ID == 0)
            {
                if(aula.Registrar())
                {
                    MessageBox.Show("Registro exitoso");
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Error al registrar");
                }
            }
            else
            {
                if (aula.Actualizar())
                {
                    MessageBox.Show("Actualizacion exitosa");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
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
            cbCentro.ResetText();
            txtNombre.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            numCapacidad.Value = 0;
            txtObservaciones.Text = string.Empty;
        }

        private void ActualizarFormulario()
        {
            lbID.Text = aula.ID.ToString();
            cbCentro.SelectedValue = aula.IdCentro;
            txtNombre.Text = aula.Descripcion;
            txtCodigo.Text = aula.Codigo;
            numCapacidad.Value = aula.Capacidad;
            txtObservaciones.Text = aula.Observaciones;
        }

        private void CargarAula()
        {
            aula.IdCentro = (int) cbCentro.SelectedValue;
            aula.Descripcion = txtNombre.Text;
            aula.Codigo = txtCodigo.Text;
            aula.Capacidad = (int) numCapacidad.Value;
            aula.Observaciones = txtObservaciones.Text;
        }

        private void CargarComboBox()
        {
            INF518.Clases.Centro centros = new INF518.Clases.Centro();

            cbCentro.DataSource = centros.Centros();
            cbCentro.ValueMember = "ID";
            cbCentro.DisplayMember = "Descripcion";
        }
        #endregion
    }
}
