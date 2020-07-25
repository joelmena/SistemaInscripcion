using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INF518.Clases;

namespace SistemaInscripcion.Usuario
{
    public partial class FrmRegistroUsuarios : Form
    {
        private Role role;
        private INF518.Clases.Usuario user;
        public FrmRegistroUsuarios(int id = 0)
        {
            InitializeComponent();
            role = new Role();
            user = new INF518.Clases.Usuario();

            if(id != 0)
            {
                user.ID = id;
                user = user.Detalle();
                txtUsuario.Enabled = false;
                txtPassword.Enabled = false;
                txtConfirmarPassword.Enabled = false;
                ActualizarFormulario();
            }

            CargarListBox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //validar que los textbox no esten vacio
            if(EsValido())
            {
                //valida que la contraseña coincida
                if(txtPassword.Text == txtConfirmarPassword.Text)
                {
                    //carga los datos de los textbox al objeto usuario
                    CargarUsuario();
                    if(user.ID == 0)
                    {
                        //si es nuevo usuario
                        if (user.Registrar())
                        {
                            MessageBox.Show("Usuario registrado");
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar el usuario");
                        }
                    }
                    else
                    {
                        //para actualizar usuario existente
                        if (user.Actualizar())
                        {
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar el usuario");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña no coincide");
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }


        #region METODOS/FUNCIONES
        private void CargarUsuario()
        {
            user.Nombre = txtNombre.Text;
            user.NombreUsuario = txtUsuario.Text;
            user.Password = txtPassword.Text;
            user.Observaciones = txtObservaciones.Text;
            user.IdRole = (int)lbxRoles.SelectedValue;
        }

        private void ActualizarFormulario()
        {
            lbID.Text = user.ID.ToString();
            txtNombre.Text = user.Nombre;
            txtUsuario.Text = user.NombreUsuario;
            txtObservaciones.Text = user.Observaciones;

        }

        private void CargarListBox()
        {
            lbxRoles.DataSource = role.Roles();
            lbxRoles.ValueMember = "ID";
            lbxRoles.DisplayMember = "Nombre";
        }
        private bool EsValido()
        {
            bool succees = true;
            if(txtNombre.Text == string.Empty)
            {
                MessageBox.Show("El nombre no debe estar en blanco");
                succees = false;
            }
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("El usuario no debe estar en blanco");
                succees = false;
            }
            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("La contraseña no debe estar en blanco");
                succees = false;
            }
            return succees;
        }

        private void LimpiarFormulario()
        {
            lbID.Text = "NUEVO";
            txtNombre.Text = String.Empty;
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmarPassword.Text = string.Empty;
            txtObservaciones.Text = string.Empty;

        }
        #endregion
    }
}
