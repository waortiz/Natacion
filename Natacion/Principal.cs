using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace Natacion
{
    public partial class Principal : Form
    {
        #region Contructores
        public Usuario Usuario { get; set; }
        #endregion

        #region Contructores
        public Principal()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void tsmiToolBar_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = tsmiToolBar.Checked;
        }

        private void tsmiStatusBar_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = tsmiStatusBar.Checked;
        }

        private void tsmiCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmiTileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tsmiTileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmiArrangeIcons_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void tsmiCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiAcercaDe_Click(object sender, EventArgs e)
        {
            AcercaDe form = new AcercaDe();
            form.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            tsslEstado.Text = "Usuario: " + this.Usuario.Nombre;
        }

        private void Principal_Activated(object sender, EventArgs e)
        {
     
        }

        private void tsmiConsultaDeportistas_Click(object sender, EventArgs e)
        {
            ListadoDeportistas form = new ListadoDeportistas();
            form.MdiParent = this;
            form.Show();
        }

        private void tsmiRegistrarDeportistas_Click(object sender, EventArgs e)
        {
            Deportista form = new Deportista();
            form.MdiParent = this;
            form.Show();
        }
        #endregion

        private void deportistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteDeportistas form = new ReporteDeportistas();
            form.MdiParent = this;
            form.Show();
        }
    }
}
