namespace Natacion
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuDeportistas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsultaDeportistas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegistrarDeportistas = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deportistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVentanas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiArrangeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiToolBar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeportistas,
            this.reportesToolStripMenuItem,
            this.mnuVentanas,
            this.mnuVer,
            this.mnuAyuda});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.mnuVentanas;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(835, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuDeportistas
            // 
            this.mnuDeportistas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiConsultaDeportistas,
            this.tsmiRegistrarDeportistas});
            this.mnuDeportistas.Name = "mnuDeportistas";
            this.mnuDeportistas.Size = new System.Drawing.Size(78, 20);
            this.mnuDeportistas.Text = "&Deportistas";
            // 
            // tsmiConsultaDeportistas
            // 
            this.tsmiConsultaDeportistas.Name = "tsmiConsultaDeportistas";
            this.tsmiConsultaDeportistas.Size = new System.Drawing.Size(199, 22);
            this.tsmiConsultaDeportistas.Text = "&Consulta de Deportistas";
            this.tsmiConsultaDeportistas.Click += new System.EventHandler(this.tsmiConsultaDeportistas_Click);
            // 
            // tsmiRegistrarDeportistas
            // 
            this.tsmiRegistrarDeportistas.Name = "tsmiRegistrarDeportistas";
            this.tsmiRegistrarDeportistas.Size = new System.Drawing.Size(199, 22);
            this.tsmiRegistrarDeportistas.Text = "&Registrar Deportistas";
            this.tsmiRegistrarDeportistas.Click += new System.EventHandler(this.tsmiRegistrarDeportistas_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deportistasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // deportistasToolStripMenuItem
            // 
            this.deportistasToolStripMenuItem.Name = "deportistasToolStripMenuItem";
            this.deportistasToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deportistasToolStripMenuItem.Text = "Deportistas";
            // 
            // mnuVentanas
            // 
            this.mnuVentanas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCascade,
            this.tsmiTileVertical,
            this.tsmiTileHorizontal,
            this.tsmiCloseAll,
            this.tsmiArrangeIcons});
            this.mnuVentanas.Name = "mnuVentanas";
            this.mnuVentanas.Size = new System.Drawing.Size(66, 20);
            this.mnuVentanas.Text = "&Ventanas";
            // 
            // tsmiCascade
            // 
            this.tsmiCascade.Name = "tsmiCascade";
            this.tsmiCascade.Size = new System.Drawing.Size(175, 22);
            this.tsmiCascade.Text = "&Cascada";
            this.tsmiCascade.Click += new System.EventHandler(this.tsmiCascade_Click);
            // 
            // tsmiTileVertical
            // 
            this.tsmiTileVertical.Name = "tsmiTileVertical";
            this.tsmiTileVertical.Size = new System.Drawing.Size(175, 22);
            this.tsmiTileVertical.Text = "Mosaico &vertical";
            this.tsmiTileVertical.Click += new System.EventHandler(this.tsmiTileVertical_Click);
            // 
            // tsmiTileHorizontal
            // 
            this.tsmiTileHorizontal.Name = "tsmiTileHorizontal";
            this.tsmiTileHorizontal.Size = new System.Drawing.Size(175, 22);
            this.tsmiTileHorizontal.Text = "Mosaico &horizontal";
            this.tsmiTileHorizontal.Click += new System.EventHandler(this.tsmiTileHorizontal_Click);
            // 
            // tsmiCloseAll
            // 
            this.tsmiCloseAll.Name = "tsmiCloseAll";
            this.tsmiCloseAll.Size = new System.Drawing.Size(175, 22);
            this.tsmiCloseAll.Text = "C&errar todo";
            this.tsmiCloseAll.Click += new System.EventHandler(this.tsmiCloseAll_Click);
            // 
            // tsmiArrangeIcons
            // 
            this.tsmiArrangeIcons.Name = "tsmiArrangeIcons";
            this.tsmiArrangeIcons.Size = new System.Drawing.Size(175, 22);
            this.tsmiArrangeIcons.Text = "&Organizar iconos";
            this.tsmiArrangeIcons.Click += new System.EventHandler(this.tsmiArrangeIcons_Click);
            // 
            // mnuVer
            // 
            this.mnuVer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiToolBar,
            this.tsmiStatusBar});
            this.mnuVer.Name = "mnuVer";
            this.mnuVer.Size = new System.Drawing.Size(35, 20);
            this.mnuVer.Text = "&Ver";
            // 
            // tsmiToolBar
            // 
            this.tsmiToolBar.Checked = true;
            this.tsmiToolBar.CheckOnClick = true;
            this.tsmiToolBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiToolBar.Name = "tsmiToolBar";
            this.tsmiToolBar.Size = new System.Drawing.Size(189, 22);
            this.tsmiToolBar.Text = "&Barra de herramientas";
            this.tsmiToolBar.Click += new System.EventHandler(this.tsmiToolBar_Click);
            // 
            // tsmiStatusBar
            // 
            this.tsmiStatusBar.Checked = true;
            this.tsmiStatusBar.CheckOnClick = true;
            this.tsmiStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiStatusBar.Name = "tsmiStatusBar";
            this.tsmiStatusBar.Size = new System.Drawing.Size(189, 22);
            this.tsmiStatusBar.Text = "&Barra de estado";
            this.tsmiStatusBar.Click += new System.EventHandler(this.tsmiStatusBar_Click);
            // 
            // mnuAyuda
            // 
            this.mnuAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.tsmiAcercaDe});
            this.mnuAyuda.Name = "mnuAyuda";
            this.mnuAyuda.Size = new System.Drawing.Size(53, 20);
            this.mnuAyuda.Text = "Ay&uda";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(144, 6);
            // 
            // tsmiAcercaDe
            // 
            this.tsmiAcercaDe.Name = "tsmiAcercaDe";
            this.tsmiAcercaDe.Size = new System.Drawing.Size(147, 22);
            this.tsmiAcercaDe.Text = "&Acerca de... ...";
            this.tsmiAcercaDe.Click += new System.EventHandler(this.tsmiAcercaDe_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsbSalir});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(835, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSalir
            // 
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(23, 22);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslEstado});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(835, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // tsslEstado
            // 
            this.tsslEstado.Name = "tsslEstado";
            this.tsslEstado.Size = new System.Drawing.Size(42, 17);
            this.tsslEstado.Text = "Estado";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liga Natación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Principal_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel tsslEstado;
        private System.Windows.Forms.ToolStripMenuItem tsmiAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem tsmiTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuVer;
        private System.Windows.Forms.ToolStripMenuItem tsmiToolBar;
        private System.Windows.Forms.ToolStripMenuItem tsmiStatusBar;
        private System.Windows.Forms.ToolStripMenuItem mnuVentanas;
        private System.Windows.Forms.ToolStripMenuItem tsmiCascade;
        private System.Windows.Forms.ToolStripMenuItem tsmiTileVertical;
        private System.Windows.Forms.ToolStripMenuItem tsmiCloseAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiArrangeIcons;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuDeportistas;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsultaDeportistas;
        private System.Windows.Forms.ToolStripMenuItem tsmiRegistrarDeportistas;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deportistasToolStripMenuItem;
    }
}



