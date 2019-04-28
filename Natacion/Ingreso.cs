using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;

namespace Natacion
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ControlUsuario control = new ControlUsuario();
            if (control.VerificarUsuario(txtUsuario.Text, txtClave.Text))
            {
                Principal form = new Principal();
                form.Usuario = new Entidades.Usuario(txtUsuario.Text, txtClave.Text);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Las credenciales autenticación ingresadas no son válidas", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void Ingreso_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
