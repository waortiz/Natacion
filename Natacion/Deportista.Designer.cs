namespace Natacion
{
    partial class Deportista
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            this.erpMensaje = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cboDisciplina = new System.Windows.Forms.ComboBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cboEPS = new System.Windows.Forms.ComboBox();
            this.txtIngresosMensuales = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblPrimerNonbre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVerListado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // erpMensaje
            // 
            this.erpMensaje.ContainerControl = this;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTelefono.Location = new System.Drawing.Point(546, 224);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(200, 20);
            this.txtTelefono.TabIndex = 9;
            this.ttMensaje.SetToolTip(this.txtTelefono, "Por favor ingrese el teléfono");
            // 
            // cboDisciplina
            // 
            this.cboDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDisciplina.FormattingEnabled = true;
            this.cboDisciplina.ItemHeight = 13;
            this.cboDisciplina.Items.AddRange(new object[] {
            "Hidroterapia",
            "Hidroaeróbicos",
            "Acondicionamiento"});
            this.cboDisciplina.Location = new System.Drawing.Point(149, 270);
            this.cboDisciplina.Name = "cboDisciplina";
            this.cboDisciplina.Size = new System.Drawing.Size(200, 21);
            this.cboDisciplina.TabIndex = 9;
            this.ttMensaje.SetToolTip(this.cboDisciplina, "Por favor seleccione la disciplina");
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSegundoApellido.Location = new System.Drawing.Point(546, 81);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(200, 20);
            this.txtSegundoApellido.TabIndex = 3;
            this.ttMensaje.SetToolTip(this.txtSegundoApellido, "Por favor ingrese el primer nombre");
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPrimerApellido.Location = new System.Drawing.Point(149, 78);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(200, 20);
            this.txtPrimerApellido.TabIndex = 2;
            this.ttMensaje.SetToolTip(this.txtPrimerApellido, "Por favor ingrese el primer apellido");
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSegundoNombre.Location = new System.Drawing.Point(546, 30);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(200, 20);
            this.txtSegundoNombre.TabIndex = 1;
            this.ttMensaje.SetToolTip(this.txtSegundoNombre, "Por favor ingrese el segundo nombre");
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Items.AddRange(new object[] {
            "Cedula",
            "Tarjeta de Identidad",
            "Cédula de Extranjería"});
            this.cboTipoDocumento.Location = new System.Drawing.Point(149, 128);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(200, 21);
            this.cboTipoDocumento.TabIndex = 4;
            this.ttMensaje.SetToolTip(this.cboTipoDocumento, "Por favor seleccione el tipo de documento");
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(546, 129);
            this.txtNumeroDocumento.MaxLength = 20;
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(200, 20);
            this.txtNumeroDocumento.TabIndex = 5;
            this.ttMensaje.SetToolTip(this.txtNumeroDocumento, "Por favor ingrese el número de documento");
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPrimerNombre.Location = new System.Drawing.Point(149, 27);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(200, 20);
            this.txtPrimerNombre.TabIndex = 0;
            this.ttMensaje.SetToolTip(this.txtPrimerNombre, "Por favor ingrese el primer nombre");
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCorreoElectronico.Location = new System.Drawing.Point(546, 179);
            this.txtCorreoElectronico.MaxLength = 100;
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(309, 20);
            this.txtCorreoElectronico.TabIndex = 20;
            this.ttMensaje.SetToolTip(this.txtCorreoElectronico, "Por favor ingrese el correo electrónico");
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDireccion.Location = new System.Drawing.Point(149, 224);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 20);
            this.txtDireccion.TabIndex = 22;
            this.ttMensaje.SetToolTip(this.txtDireccion, "Por favor ingrese la dirección");
            // 
            // cboEPS
            // 
            this.cboEPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEPS.FormattingEnabled = true;
            this.cboEPS.ItemHeight = 13;
            this.cboEPS.Items.AddRange(new object[] {
            "COOMEVA",
            "SURA",
            "SALUD TOTAL"});
            this.cboEPS.Location = new System.Drawing.Point(546, 270);
            this.cboEPS.Name = "cboEPS";
            this.cboEPS.Size = new System.Drawing.Size(200, 21);
            this.cboEPS.TabIndex = 24;
            this.ttMensaje.SetToolTip(this.cboEPS, "Por favor seleccione la EPS");
            // 
            // txtIngresosMensuales
            // 
            this.txtIngresosMensuales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtIngresosMensuales.Location = new System.Drawing.Point(149, 316);
            this.txtIngresosMensuales.MaxLength = 100;
            this.txtIngresosMensuales.Name = "txtIngresosMensuales";
            this.txtIngresosMensuales.Size = new System.Drawing.Size(200, 20);
            this.txtIngresosMensuales.TabIndex = 26;
            this.ttMensaje.SetToolTip(this.txtIngresosMensuales, "Por favor ingrese los ingresos mensuales");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIngresos);
            this.groupBox1.Controls.Add(this.txtIngresosMensuales);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboEPS);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCorreoElectronico);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.lblDisciplina);
            this.groupBox1.Controls.Add(this.cboDisciplina);
            this.groupBox1.Controls.Add(this.lblSegundoApellido);
            this.groupBox1.Controls.Add(this.txtSegundoApellido);
            this.groupBox1.Controls.Add(this.lblPrimerApellido);
            this.groupBox1.Controls.Add(this.txtPrimerApellido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSegundoNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboTipoDocumento);
            this.groupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNumeroDocumento);
            this.groupBox1.Controls.Add(this.txtNumeroDocumento);
            this.groupBox1.Controls.Add(this.lblPrimerNonbre);
            this.groupBox1.Controls.Add(this.txtPrimerNombre);
            this.groupBox1.Location = new System.Drawing.Point(28, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 400);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Básicos";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(15, 323);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(100, 13);
            this.lblIngresos.TabIndex = 27;
            this.lblIngresos.Text = "Ingresos mensuales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "EPS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Correo electrónico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Teléfono";
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Location = new System.Drawing.Point(15, 273);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(52, 13);
            this.lblDisciplina.TabIndex = 17;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Location = new System.Drawing.Point(412, 84);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(89, 13);
            this.lblSegundoApellido.TabIndex = 14;
            this.lblSegundoApellido.Text = "Segundo apellido";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Location = new System.Drawing.Point(15, 81);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(75, 13);
            this.lblPrimerApellido.TabIndex = 12;
            this.lblPrimerApellido.Text = "Primer apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Segundo nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de documento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(149, 176);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de nacimiento";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(412, 136);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(115, 13);
            this.lblNumeroDocumento.TabIndex = 4;
            this.lblNumeroDocumento.Text = "Número de documento";
            // 
            // lblPrimerNonbre
            // 
            this.lblPrimerNonbre.AutoSize = true;
            this.lblPrimerNonbre.Location = new System.Drawing.Point(15, 30);
            this.lblPrimerNonbre.Name = "lblPrimerNonbre";
            this.lblPrimerNonbre.Size = new System.Drawing.Size(74, 13);
            this.lblPrimerNonbre.TabIndex = 2;
            this.lblPrimerNonbre.Text = "Primer nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(777, 449);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 29);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVerListado
            // 
            this.btnVerListado.Location = new System.Drawing.Point(632, 449);
            this.btnVerListado.Name = "btnVerListado";
            this.btnVerListado.Size = new System.Drawing.Size(125, 29);
            this.btnVerListado.TabIndex = 14;
            this.btnVerListado.Text = "Ver listado";
            this.btnVerListado.UseVisualStyleBackColor = true;
            this.btnVerListado.Click += new System.EventHandler(this.btnVerListado_Click);
            // 
            // Deportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 508);
            this.Controls.Add(this.btnVerListado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Name = "Deportista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deportista";
            this.Load += new System.EventHandler(this.Deportista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpMensaje)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider erpMensaje;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.ComboBox cboDisciplina;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label lblPrimerNonbre;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboEPS;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.TextBox txtIngresosMensuales;
        private System.Windows.Forms.Button btnVerListado;
    }
}

