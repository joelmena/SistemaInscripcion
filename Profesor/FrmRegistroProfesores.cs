using INF518.Clases;
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

namespace SistemaInscripcion.Profesor
{
    public partial class FrmRegistroProfesores : Form
    {
        private INF518.Clases.Profesor profe;
        private readonly int userId;
        public FrmRegistroProfesores(int userId, int profesorId = 0)
        {
            InitializeComponent();
            profe = new INF518.Clases.Profesor();
            this.userId = userId;

            if (profesorId != 0)
            {
                profe.ID = profesorId;
                profe = profe.Detalle();
            }
            CargarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            profe.Nombre = txtNombre.Text;
            profe.Apellidos = txtApellidos.Text;
            profe.Direccion = txtDireccion.Text;
            profe.Email = txtEmail.Text;
            profe.Observaciones = txtObservaciones.Text;

            profe.FechaNacimiento = dpFechaNacimiento.Value;

            profe.Sexo = (rbMasculino.Checked) ? 'M' : 'F';

            profe.TelefonoMovil = mkTelefonoMovil.Text.Replace("-", string.Empty);
            profe.TelefonoCasa = mkTelefonoCasa.Text.Replace("-", string.Empty);
            profe.Cedula = mkCedula.Text.Replace("-", string.Empty);

            profe.UrlFoto = pbFoto.ImageLocation ?? string.Empty;

            profe.IdEstadoCivil = (int)cbEstadoCivil.SelectedValue;

            if (profe.ID == 0)
            {
                if (profe.Registrar(userId))
                {
                    MessageBox.Show("Registrado con exito");
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                if (profe.Actualizar(userId))
                {
                    MessageBox.Show("Actualizado con exito");
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            openFile.Filter = "Archivos de imagen | *.jpg; *.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pbFoto.ImageLocation = openFile.FileName;
            }
            openFile.Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pbFoto.ImageLocation = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "default.png");
        }



        #region METODOS/FUNCIONES
        private void CargarFormulario()
        {
            EstadoCivil estadoCivil = new EstadoCivil();

            cbEstadoCivil.DisplayMember = "Nombre";
            cbEstadoCivil.ValueMember = "ID";
            cbEstadoCivil.DataSource = estadoCivil.Listado();

            if (profe.ID != 0)
            {
                cbEstadoCivil.SelectedValue = profe.IdEstadoCivil;

                txtNombre.Text = profe.Nombre;
                txtApellidos.Text = profe.Apellidos;
                txtDireccion.Text = profe.Direccion;
                txtEmail.Text = profe.Email;
                txtObservaciones.Text = profe.Observaciones;

                pbFoto.ImageLocation = profe.UrlFoto;

                dpFechaNacimiento.Value = profe.FechaNacimiento;

                if (profe.Sexo == 'M')
                {
                    rbMasculino.Checked = true;
                }
                else
                {
                    rbFemenino.Checked = true;
                }

                mkCedula.Text = profe.Cedula;
                mkTelefonoCasa.Text = profe.TelefonoCasa;
                mkTelefonoMovil.Text = profe.TelefonoMovil;
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtObservaciones.Text = string.Empty;

            dpFechaNacimiento.ResetText();

            rbFemenino.Checked = false;
            rbMasculino.Checked = false;

            mkCedula.Text = string.Empty;
            mkTelefonoCasa.Text = string.Empty;
            mkTelefonoMovil.Text = string.Empty;

            cbEstadoCivil.ResetText();
        }
        #endregion
    }
}
