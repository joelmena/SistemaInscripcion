using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcion.Centro
{
    public partial class FrmRegistroCentros : Form
    {
        INF518.Clases.Centro centro;
        public FrmRegistroCentros(int idCentro = 0)
        {
            InitializeComponent();
            centro = new INF518.Clases.Centro();

            LimpiarFormulario();

            if(idCentro != 0)
            {
                centro.ID = idCentro;
                centro = centro.Detalle();
                ActualizarFormulario();
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            centro.Descripcion = txtNombre.Text ?? "";
            centro.NombreCorto = txtNombreCorto.Text ?? "";
            centro.WebSite = txtWebSite.Text ?? "";
            centro.Telefono = mkTelefono.Text ?? "";
            centro.Observaciones = txtObservaciones.Text ?? "";
            centro.UrlLogo = pbLogo.ImageLocation ?? "";

            if (centro.ID == 0)
            {
                if (centro.Registrar())
                {
                    MessageBox.Show("Registro exitoso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Error durante el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (centro.Actualizar())
                {
                    MessageBox.Show("Actualizacion exitosa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error durante e la actualizacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Archivo de imagen | *.jpg; *.png";

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                pbLogo.ImageLocation = openFile.FileName;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pbLogo.ImageLocation = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "defaultLogo.png");
        }


        #region METODOS/FUNCIONES
        private void ActualizarFormulario()
        {
            lbID.Text = centro.ID.ToString();
            txtNombre.Text = centro.Descripcion;
            txtNombreCorto.Text = centro.NombreCorto;
            txtWebSite.Text = centro.WebSite;
            mkTelefono.Text = centro.Telefono;
            txtObservaciones.Text = centro.Observaciones;
            pbLogo.ImageLocation = centro.UrlLogo;
        }
        private void LimpiarFormulario()
        {
            pbLogo.ImageLocation = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "defaultLogo.png");
            txtNombre.Text = string.Empty;
            txtNombreCorto.Text = string.Empty;
            txtWebSite.Text = string.Empty;
            mkTelefono.Text = string.Empty;
            txtObservaciones.Text = string.Empty;
        }
        #endregion

    }
}
