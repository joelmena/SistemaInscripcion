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

namespace SistemaInscripcion.Seccion
{
    public partial class FrmCrearSecciones : Form
    {
        INF518.Clases.Seccion seccion;
        public FrmCrearSecciones(int id = 0)
        {
            InitializeComponent();
            seccion = new INF518.Clases.Seccion();
            CargarComboBox();
            LimpiarFormulario();

            if(id != 0)
            {
                seccion.ID = id;
                seccion = seccion.Detalle();
                ActualizarFormulario();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CargarSeccion();

            if(seccion.ID == 0)
            {
                if (seccion.Registrar())
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
                if (seccion.Actualizar())
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
            cbAula.ResetText();
            cbAsignatura.ResetText();
            cbCarrera.ResetText();
            cbProfesor.ResetText();
            cbDia1.SelectedIndex = 0;
            cbDia2.SelectedIndex = 0;
            dpHoraInicio1.ResetText();
            dpHoraFin1.ResetText();
            numCapacidad.Value = 1;
            txtObservaciones.Text = string.Empty;
        }
        private void ActualizarFormulario()
        {
            lbID.Text = seccion.ID.ToString();
            cbCentro.SelectedValue = seccion.IdCentro;
            cbAula.SelectedValue = seccion.IdAula;
            cbAsignatura.SelectedValue = seccion.IdAsignatura;
            cbCarrera.SelectedValue = seccion.IdCarrera;
            cbProfesor.SelectedValue = seccion.IdProfesor;
            cbDia1.Text = seccion.Dia1;
            dpHoraInicio1.Value = seccion.HoraInicio1;
            dpHoraFin1.Value = seccion.HoraFin1;
            cbDia2.Text = seccion.Dia2;
            dpHoraInicio2.Value = seccion.HoraInicio2;
            dpHoraFin2.Value = seccion.HoraFin2;
            numCapacidad.Value = seccion.Capacidad;
            txtObservaciones.Text = seccion.Observaciones;
        }

        private void CargarComboBox()
        {
            INF518.Clases.Centro centro = new INF518.Clases.Centro();
            INF518.Clases.Aula aula = new INF518.Clases.Aula();
            INF518.Clases.Asignatura asignatura = new INF518.Clases.Asignatura();
            INF518.Clases.Carrera carrera = new INF518.Clases.Carrera();
            INF518.Clases.Profesor profe = new INF518.Clases.Profesor();

            cbCentro.DataSource = centro.Centros();
            cbCentro.ValueMember = "ID";
            cbCentro.DisplayMember = "Descripcion";

            cbAula.DataSource = aula.Aulas();
            cbAula.ValueMember = "ID";
            cbAula.DisplayMember = "Descripcion";

            cbCarrera.DataSource = carrera.Carreras();
            cbCarrera.ValueMember = "ID";
            cbCarrera.DisplayMember = "Descripcion";

            cbAsignatura.DataSource = asignatura.Asignaturas();
            cbAsignatura.ValueMember = "ID";
            cbAsignatura.DisplayMember = "Descripcion";

            cbProfesor.DataSource = profe.CbProfesores();
            cbProfesor.ValueMember = "ID";
            cbProfesor.DisplayMember = "Nombre";

            cbDia1.SelectedIndex = 0;
            cbDia2.SelectedIndex = 0;

        }

        private void CargarSeccion()
        {
            seccion.IdCentro = (int)cbCentro.SelectedValue;
            seccion.IdAula = (int)cbAula.SelectedValue;
            seccion.IdCarrera = (int)cbCarrera.SelectedValue;
            seccion.IdAsignatura = (int)cbAsignatura.SelectedValue;
            seccion.IdProfesor = (int)cbProfesor.SelectedValue;
            seccion.Dia1 = cbDia1.SelectedItem.ToString();
            seccion.HoraInicio1 = Convert.ToDateTime(dpHoraInicio1.Value.ToShortTimeString());
            seccion.HoraFin1 = Convert.ToDateTime(dpHoraFin1.Value.ToShortTimeString());
            seccion.Dia2 = cbDia2.SelectedItem.ToString();
            seccion.HoraInicio2 = Convert.ToDateTime(dpHoraInicio2.Value.ToShortTimeString());
            seccion.HoraFin2 = Convert.ToDateTime(dpHoraFin2.Value.ToShortTimeString());
            seccion.Capacidad = (int)numCapacidad.Value;
            seccion.Observaciones = txtObservaciones.Text;
        }
        private bool ValidarHorario()
        {
            if(dpHoraInicio1.Value > dpHoraFin1.Value)
            {
                MessageBox.Show("La hora de inicio 1 debe ser menor a la hora final 1");
                return false;
            }
            else if(dpHoraFin1.Value < dpHoraInicio1.Value)
            {
                MessageBox.Show("La hora final 1 debe ser mayor a la hora inicial 1");
                return false;
            }
            if (dpHoraInicio2.Value > dpHoraFin2.Value)
            {
                MessageBox.Show("La hora de inicio 2 debe ser menor a la hora final 2");
                return false;
            }
            else if (dpHoraFin2.Value < dpHoraInicio2.Value)
            {
                MessageBox.Show("La hora final 2 debe ser mayor a la hora inicial 2");
                return false;
            }
            return true;
        }
        #endregion
    }

}
