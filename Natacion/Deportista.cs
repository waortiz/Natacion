using Negocio;
using System;
using System.Windows.Forms;

namespace Natacion
{
    public partial class Deportista : Form
    {
        protected int valor = 10;

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
            if (string.IsNullOrEmpty(txtPrimerNombre.Text.Trim()))
            {
                erpMensaje.SetError(txtPrimerNombre, "Por favor ingrese el primer nombre");
                return;
            }
            else
            {
                erpMensaje.SetError(txtPrimerNombre, null);
            }

            if (string.IsNullOrEmpty(txtPrimerApellido.Text.Trim()))
            {
                erpMensaje.SetError(txtPrimerApellido, "Por favor ingrese el primer apellido");
                return;
            }
            else
            {
                erpMensaje.SetError(txtPrimerApellido, null);
            }

            if (cboTipoDocumento.SelectedItem == null)
            {
                erpMensaje.SetError(cboTipoDocumento, "Por favor seleccione el tipo de documento");
                return;
            }
            else
            {
                erpMensaje.SetError(cboTipoDocumento, null);
            }

            if (string.IsNullOrEmpty(txtNumeroDocumento.Text.Trim()))
            {
                erpMensaje.SetError(txtNumeroDocumento, "Por favor ingrese el número de documento");
                return;
            }
            else
            {
                erpMensaje.SetError(txtNumeroDocumento, null);
            }

            DateTime fechaNacimiento = dtpFechaNacimiento.Value;
            if (fechaNacimiento > DateTime.Now)
            {
                erpMensaje.SetError(dtpFechaNacimiento, "La fecha de nacimiento no debe ser mayor a la fecha del sistema");
                return;
            }
            else
            {
                erpMensaje.SetError(dtpFechaNacimiento, null);
            }

            if (string.IsNullOrEmpty(txtCorreoElectronico.Text.Trim()))
            {
                erpMensaje.SetError(txtCorreoElectronico, "Por favor ingrese el correo electrónico");
                return;
            }
            else
            {
                erpMensaje.SetError(txtCorreoElectronico, null);
            }

            if (string.IsNullOrEmpty(txtDireccion.Text.Trim()))
            {
                erpMensaje.SetError(txtDireccion, "Por favor ingrese la dirección");
                return;
            }
            else
            {
                erpMensaje.SetError(txtDireccion, null);
            }

            if (string.IsNullOrEmpty(txtTelefono.Text.Trim()))
            {
                erpMensaje.SetError(txtTelefono, "Por favor ingrese el teléfono");
                return;
            }
            else
            {
                erpMensaje.SetError(txtTelefono, null);
            }

            if (cboDisciplina.SelectedItem == null)
            {
                erpMensaje.SetError(cboDisciplina, "Por favor seleccione la disciplina");
                return;
            }
            else
            {
                erpMensaje.SetError(cboDisciplina, null);
            }

            if (cboEPS.SelectedItem == null)
            {
                erpMensaje.SetError(cboEPS, "Por favor seleccione la EPS");
                return;
            }
            else
            {
                erpMensaje.SetError(cboEPS, null);
            }

            Entidades.Deportista deportista = new Entidades.Deportista()
            {
                CorreoElectronico = txtCorreoElectronico.Text,
                Direccion = txtDireccion.Text,
                Disciplina = new Entidades.Disciplina()
                {
                    Nombre = cboDisciplina.SelectedItem as string
                },
                EPS = new Entidades.EPS()
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
                TipoDocumento = new Entidades.TipoDocumento()
                {
                    Nombre = cboTipoDocumento.SelectedItem as string
                }
            };

            ControlDeportista control = new ControlDeportista();
            control.IngresarDeportista(deportista);

            MessageBox.Show("Los datos se han guardado exitosamente");
        }

        private void Deportista_Load(object sender, EventArgs e)
        {

        }
    }
}
