using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Natacion
{
    public partial class Deportista : Form
    {
        public Deportista()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!ValidarDatos())
            {
                return;
            }

            var deportista = new Entidades.Deportista()
            {
                CorreoElectronico = txtCorreoElectronico.Text,
                Direccion = txtDireccion.Text,
                Disciplina = cboDisciplina.SelectedItem as Disciplina,
                EPS = cboEPS.SelectedItem as EPS,
                FechaNacimiento = dtpFechaNacimiento.Value,
                NumeroDocumento = txtNumeroDocumento.Text,
                PrimerApellido = txtPrimerApellido.Text,
                PrimerNombre = txtPrimerNombre.Text,
                SegundoApellido = txtPrimerApellido.Text,
                SegundoNombre = txtSegundoNombre.Text,
                IngresosMensuales = double.Parse(txtIngresosMensuales.Text),
                Telefono = txtTelefono.Text,
                TipoDocumento = cboTipoDocumento.SelectedItem as TipoDocumento
            };

            try
            {
                ControlDeportista control = new ControlDeportista();
                control.IngresarDeportista(deportista);

                MessageBox.Show("Los datos se han guardado exitosamente");
            }
            catch(Exception exc)
            {
                MessageBox.Show("Ocurrió un error al guardar el deportista");
                //Log de errores. Log.Error(exc);
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtPrimerNombre.Text.Trim()))
            {
                erpMensaje.SetError(txtPrimerNombre, "Por favor ingrese el primer nombre");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtPrimerNombre, null);
            }

            if (string.IsNullOrEmpty(txtPrimerApellido.Text.Trim()))
            {
                erpMensaje.SetError(txtPrimerApellido, "Por favor ingrese el primer apellido");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtPrimerApellido, null);
            }

            if (cboTipoDocumento.SelectedItem == null)
            {
                erpMensaje.SetError(cboTipoDocumento, "Por favor seleccione el tipo de documento");
                return false;
            }
            else
            {
                erpMensaje.SetError(cboTipoDocumento, null);
            }

            if (string.IsNullOrEmpty(txtNumeroDocumento.Text.Trim()))
            {
                erpMensaje.SetError(txtNumeroDocumento, "Por favor ingrese el número de documento");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtNumeroDocumento, null);
            }

            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            if (fechaNacimiento > DateTime.Now)
            {
                erpMensaje.SetError(dtpFechaNacimiento, "La fecha de nacimiento no debe ser mayor a la fecha del sistema");
                return false;
            }
            else
            {
                erpMensaje.SetError(dtpFechaNacimiento, null);
            }

            if (string.IsNullOrEmpty(txtCorreoElectronico.Text.Trim()))
            {
                erpMensaje.SetError(txtCorreoElectronico, "Por favor ingrese el correo electrónico");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtCorreoElectronico, null);
            }

            if (string.IsNullOrEmpty(txtDireccion.Text.Trim()))
            {
                erpMensaje.SetError(txtDireccion, "Por favor ingrese la dirección");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtDireccion, null);
            }

            if (string.IsNullOrEmpty(txtTelefono.Text.Trim()))
            {
                erpMensaje.SetError(txtTelefono, "Por favor ingrese el teléfono");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtTelefono, null);
            }

            if (cboDisciplina.SelectedItem == null)
            {
                erpMensaje.SetError(cboDisciplina, "Por favor seleccione la disciplina");
                return false;
            }
            else
            {
                erpMensaje.SetError(cboDisciplina, null);
            }

            if (cboEPS.SelectedItem == null)
            {
                erpMensaje.SetError(cboEPS, "Por favor seleccione la EPS");
                return false;
            }
            else
            {
                erpMensaje.SetError(cboEPS, null);
            }

            if (string.IsNullOrEmpty(txtIngresosMensuales.Text.Trim()))
            {
                erpMensaje.SetError(txtIngresosMensuales, "Por favor ingrese los ingresos mensuales");
                return false;
            }
            else
            {
                erpMensaje.SetError(txtIngresosMensuales, null);
            }

            return true;
        }

        private void Deportista_Load(object sender, EventArgs e)
        {
            IControlMaestro control = new ControlMaestro();
            var tiposDocumento = control.ObtenerTiposDocumento();
            cboTipoDocumento.DataSource = tiposDocumento;
            cboTipoDocumento.DisplayMember = "Nombre";
            cboTipoDocumento.SelectedItem = null;

            var eps = control.ObtenerEPS();
            cboEPS.DataSource = eps;
            cboEPS.DisplayMember = "Nombre";
            cboEPS.SelectedItem = null;

            var disciplinas = control.ObtenerDisciplinas();
            cboDisciplina.DataSource = disciplinas;
            cboDisciplina.DisplayMember = "Nombre";
            cboDisciplina.SelectedItem = null;

            var sexo = control.ObtenerSexo();
            cboSexo.DataSource = sexo;
            cboSexo.DisplayMember = "Nombre";
            cboSexo.SelectedItem = null;

        }

        private void btnVerListado_Click(object sender, EventArgs e)
        {
            ListadoDeportistas listado = new ListadoDeportistas();
            listado.ShowDialog();
        }

        private void TxtIngresosMensuales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((int)e.KeyChar == 8 ||
    (int)e.KeyChar >= 48 && (int)e.KeyChar <= 59))
            {
                e.Handled = true;
            }
        }
    }
}
