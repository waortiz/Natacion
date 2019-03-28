using Negocio;
using System;
using System.Windows.Forms;

namespace Natacion
{
    public partial class ListadoDeportistas : Form
    {
        public ListadoDeportistas()
        {
            InitializeComponent();
        }

        private void ListadoDeportistas_Load(object sender, EventArgs e)
        {

        }

        public void EliminarDeportista()
        {
            if (dgvDeportistas.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Está seguro de eliminar el deportista",
                                   Text, MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        long idDeportista = ((Entidades.Deportista)dgvDeportistas.SelectedRows[0].DataBoundItem).Id;
                        IControlDeportista control = new ControlDeportista();
                        control.EliminarDeportista(idDeportista);
                        ConsultarDeportistas();
                        MessageBox.Show("El deportista se eliminó correctamente", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("No se pudo eliminar el deportista. " + exc.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public Entidades.Deportista ObtenerDeportistaSeleccionado()
        {
            if (dgvDeportistas.SelectedRows.Count > 0)
            {
                return (Entidades.Deportista)(dgvDeportistas.SelectedRows[0].DataBoundItem);
            }
            else
            {
                return null;
            }
        }

        private void ConsultarDeportistas()
        {
            IControlDeportista control = new ControlDeportista();

            dgvDeportistas.AutoGenerateColumns = false;
            dgvDeportistas.DataSource = control.ConsultarDeportistas(txtNumeroDocumento.Text, txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarDeportista();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarDeportistas();
        }
    }
}
