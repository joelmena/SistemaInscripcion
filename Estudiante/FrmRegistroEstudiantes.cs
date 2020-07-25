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
using INF518.Clases;

namespace SistemaInscripcion.Estudiante
{
    public partial class FrmRegistroEstudiantes : Form
    {
        private INF518.Clases.Estudiante est;
        private readonly int userId;
        public FrmRegistroEstudiantes(int userId, int estudianteId = 0)
        {
            InitializeComponent();
            est = new INF518.Clases.Estudiante();
            this.userId = userId;

            if(estudianteId != 0)
            {
                est.ID = estudianteId;
                est = est.Detalle();
            }
            ActualizarFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            est.Nombre = txtNombre.Text;
            est.Apellidos = txtApellidos.Text;
            est.Direccion = txtDireccion.Text;
            est.Email = txtEmail.Text;
            est.Observaciones = txtObservaciones.Text;

            est.FechaNacimiento = dpFechaNacimiento.Value;

            est.Sexo = (rbMasculino.Checked) ? 'M' : 'F';

            est.TelefonoMovil = mkTelefonoMovil.Text.Replace("-", string.Empty);
            est.TelefonoCasa = mkTelefonoCasa.Text.Replace("-", string.Empty);
            est.Cedula = mkCedula.Text.Replace("-", string.Empty);

            est.UrlFoto = pbFoto.ImageLocation ?? string.Empty;

            est.IdEstadoCivil = (int ) cbEstadoCivil.SelectedValue;
            est.IdCarrera = (int) cbCarrera.SelectedValue;
            est.IdTipoEstudiante = (int) cbTipoEstudiante.SelectedValue;

            if(est.ID == 0)
            {
                if (est.Registrar(userId))
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
                if (est.Actualizar(userId))
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

            if(openFile.ShowDialog() == DialogResult.OK)
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
        private void ActualizarFormulario()
        {
            INF518.Clases.Carrera carrera = new INF518.Clases.Carrera();
            TipoEstudiante tipoEstudiante = new TipoEstudiante();
            EstadoCivil estadoCivil = new EstadoCivil();

            cbCarrera.DisplayMember = "Descripcion";
            cbCarrera.ValueMember = "ID";
            cbCarrera.DataSource = carrera.Carreras();
            

            cbTipoEstudiante.DisplayMember = "Descripcion";
            cbTipoEstudiante.ValueMember = "ID";
            cbTipoEstudiante.DataSource = tipoEstudiante.Listado();

            cbEstadoCivil.DisplayMember = "Nombre";
            cbEstadoCivil.ValueMember = "ID";
            cbEstadoCivil.DataSource = estadoCivil.Listado();

            if(est.ID != 0)
            {
                cbCarrera.SelectedValue = est.IdCarrera;
                cbTipoEstudiante.SelectedValue = est.IdTipoEstudiante;
                cbEstadoCivil.SelectedValue = est.IdEstadoCivil;

                txtMatricula.Text = est.Matricula.ToString();
                txtNombre.Text = est.Nombre;
                txtApellidos.Text = est.Apellidos;
                txtDireccion.Text = est.Direccion;
                txtEmail.Text = est.Email;
                txtObservaciones.Text = est.Observaciones;
                txtBalance.Text = est.Balance.ToString();

                pbFoto.ImageLocation = est.UrlFoto;

                dpFechaNacimiento.Value = est.FechaNacimiento;

                if(est.Sexo == 'M')
                {
                    rbMasculino.Checked = true;
                }
                else
                {
                    rbFemenino.Checked = true;
                }

                mkCedula.Text = est.Cedula;
                mkTelefonoCasa.Text = est.TelefonoCasa;
                mkTelefonoMovil.Text = est.TelefonoMovil;
            }
            
            txtBalance.Text = txtBalance.Text != string.Empty ? txtBalance.Text : "0.00";
        }

        private void LimpiarFormulario()
        {
            txtMatricula.Text = string.Empty;
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
            cbCarrera.ResetText();
            cbTipoEstudiante.ResetText();
        }
        #endregion

    }
}
