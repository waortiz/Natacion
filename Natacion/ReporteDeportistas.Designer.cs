namespace Natacion
{
    partial class ReporteDeportistas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvReporteDeportistas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSDeportista = new Natacion.DSDeportista();
            this.DeportistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DSDeportista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeportistaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rvReporteDeportistas
            // 
            this.rvReporteDeportistas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSDeportista";
            reportDataSource1.Value = this.DeportistaBindingSource;
            this.rvReporteDeportistas.LocalReport.DataSources.Add(reportDataSource1);
            this.rvReporteDeportistas.LocalReport.ReportEmbeddedResource = "Natacion.rptReporteDeportistas.rdlc";
            this.rvReporteDeportistas.LocalReport.ReportPath = "rptReporteDeportistas.rdlc";
            this.rvReporteDeportistas.Location = new System.Drawing.Point(0, 0);
            this.rvReporteDeportistas.Name = "rvReporteDeportistas";
            this.rvReporteDeportistas.Size = new System.Drawing.Size(800, 450);
            this.rvReporteDeportistas.TabIndex = 0;
            // 
            // DSDeportista
            // 
            this.DSDeportista.DataSetName = "DSDeportista";
            this.DSDeportista.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DeportistaBindingSource
            // 
            this.DeportistaBindingSource.DataMember = "Deportista";
            this.DeportistaBindingSource.DataSource = this.DSDeportista;
            // 
            // ReporteDeportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvReporteDeportistas);
            this.Name = "ReporteDeportistas";
            this.Text = "ReporteDeportistas";
            this.Load += new System.EventHandler(this.ReporteDeportistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSDeportista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeportistaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvReporteDeportistas;
        private System.Windows.Forms.BindingSource DeportistaBindingSource;
        private DSDeportista DSDeportista;
    }
}