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
                Disciplina = new Disciplina()
                {
                    Nombre = cboDisciplina.SelectedItem as string
                },
                EPS = new EPS()
                {
                    Nombre = cboEPS.SelectedItem as string
                },
                FechaNacimiento = dtpFechaNacimiento.Value,
                NumeroDocumento = txtNumeroDocumento.Text,
                PrimerApellido = txtPrimerApellido.Text,
                PrimerNombre = txtPrimerNombre.Text,
                SegundoApellido = txtPrimerApellido.Text,
                SegundoNombre = txtSegundoNombre.Text,
                Telefono = txtTelefono.Text,
                TipoDocumento = cboTipoDocumento.SelectedItem as TipoDocumento
            };

            ControlDeportista control = new ControlDeportista();
            control.IngresarDeportista(deportista);

            MessageBox.Show("Los datos se han guardado exitosamente");
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

            if(((TipoDocumento)cboTipoDocumento.SelectedItem).Id != (int)TipoDocumentoEnum.Cedula)
            {
                erpMensaje.SetError(cboTipoDocumento, 
                    "Solo se admiten mayores de edad nacionales");
                return false;
            }
            else
            {
                erpMensaje.SetError(cboTipoDocumento, null);
            }

            return true;
        }

        private void Deportista_Load(object sender, EventArgs e)
        {
            IControlMaestro control = new ControlMaestro();
            List<TipoDocumento> tiposDocumento = control.ObtenerTiposDocumento();
            cboTipoDocumento.DataSource = tiposDocumento;
            cboTipoDocumento.DisplayMember = "Nombre";
            cboTipoDocumento.SelectedItem = null;
            dtpFechaNacimiento.ResetText();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMostrarSalario_Click(object sender, EventArgs e)
        {
            double salario = 0;
            double.TryParse(txtIngresosMensuales.Text, out salario);
            MessageBox.Show(string.Format(
                "Los ingresos mensuales son {0}",
                salario.ToString("€ ###,###")));
        }

        private void btnMostrarFechaNaicmiento_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format(
                           "La fecha de nacimiento es {0}",
                           dtpFechaNacimiento.Value.
                           ToString("dd/MM/yyyy")));
        }
    }
}
