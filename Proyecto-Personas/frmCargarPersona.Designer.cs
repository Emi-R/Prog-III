namespace negocio
{
    partial class frmCargarPersona
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
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.tbxDni = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.gbxEstadoCiv = new System.Windows.Forms.GroupBox();
            this.rbtJuntado = new System.Windows.Forms.RadioButton();
            this.rbtSeparado = new System.Windows.Forms.RadioButton();
            this.rbtDivorciado = new System.Windows.Forms.RadioButton();
            this.rbtCasado = new System.Windows.Forms.RadioButton();
            this.rbtSoltero = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtFem = new System.Windows.Forms.RadioButton();
            this.rbtMasc = new System.Windows.Forms.RadioButton();
            this.gbxEstadoCiv.SuspendLayout();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(54, 52);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(231, 20);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "Ingrese los datos de la persona";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(91, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Persona nueva";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(24, 132);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(77, 129);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(219, 20);
            this.tbxApellido.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 169);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNombre.Location = new System.Drawing.Point(77, 166);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(219, 20);
            this.tbxNombre.TabIndex = 2;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(33, 95);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 6;
            this.lblDni.Text = "DNI:";
            // 
            // tbxDni
            // 
            this.tbxDni.Location = new System.Drawing.Point(77, 92);
            this.tbxDni.Name = "tbxDni";
            this.tbxDni.Size = new System.Drawing.Size(133, 20);
            this.tbxDni.TabIndex = 0;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(85, 279);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(159, 13);
            this.lblFechaNac.TabIndex = 8;
            this.lblFechaNac.Text = "Seleccione fecha de nacimiento";
            // 
            // gbxEstadoCiv
            // 
            this.gbxEstadoCiv.Controls.Add(this.rbtJuntado);
            this.gbxEstadoCiv.Controls.Add(this.rbtSeparado);
            this.gbxEstadoCiv.Controls.Add(this.rbtDivorciado);
            this.gbxEstadoCiv.Controls.Add(this.rbtCasado);
            this.gbxEstadoCiv.Controls.Add(this.rbtSoltero);
            this.gbxEstadoCiv.Location = new System.Drawing.Point(27, 340);
            this.gbxEstadoCiv.Name = "gbxEstadoCiv";
            this.gbxEstadoCiv.Size = new System.Drawing.Size(282, 142);
            this.gbxEstadoCiv.TabIndex = 5;
            this.gbxEstadoCiv.TabStop = false;
            this.gbxEstadoCiv.Text = "Estado Civil";
            // 
            // rbtJuntado
            // 
            this.rbtJuntado.AutoSize = true;
            this.rbtJuntado.Location = new System.Drawing.Point(14, 111);
            this.rbtJuntado.Name = "rbtJuntado";
            this.rbtJuntado.Size = new System.Drawing.Size(63, 17);
            this.rbtJuntado.TabIndex = 4;
            this.rbtJuntado.Text = "Juntado";
            this.rbtJuntado.UseVisualStyleBackColor = true;
            // 
            // rbtSeparado
            // 
            this.rbtSeparado.AutoSize = true;
            this.rbtSeparado.Location = new System.Drawing.Point(14, 88);
            this.rbtSeparado.Name = "rbtSeparado";
            this.rbtSeparado.Size = new System.Drawing.Size(71, 17);
            this.rbtSeparado.TabIndex = 3;
            this.rbtSeparado.Text = "Separado";
            this.rbtSeparado.UseVisualStyleBackColor = true;
            // 
            // rbtDivorciado
            // 
            this.rbtDivorciado.AutoSize = true;
            this.rbtDivorciado.Location = new System.Drawing.Point(14, 65);
            this.rbtDivorciado.Name = "rbtDivorciado";
            this.rbtDivorciado.Size = new System.Drawing.Size(76, 17);
            this.rbtDivorciado.TabIndex = 2;
            this.rbtDivorciado.Text = "Divorciado";
            this.rbtDivorciado.UseVisualStyleBackColor = true;
            // 
            // rbtCasado
            // 
            this.rbtCasado.AutoSize = true;
            this.rbtCasado.Location = new System.Drawing.Point(14, 42);
            this.rbtCasado.Name = "rbtCasado";
            this.rbtCasado.Size = new System.Drawing.Size(61, 17);
            this.rbtCasado.TabIndex = 1;
            this.rbtCasado.Text = "Casado";
            this.rbtCasado.UseVisualStyleBackColor = true;
            // 
            // rbtSoltero
            // 
            this.rbtSoltero.AutoSize = true;
            this.rbtSoltero.Checked = true;
            this.rbtSoltero.Location = new System.Drawing.Point(14, 19);
            this.rbtSoltero.Name = "rbtSoltero";
            this.rbtSoltero.Size = new System.Drawing.Size(58, 17);
            this.rbtSoltero.TabIndex = 0;
            this.rbtSoltero.TabStop = true;
            this.rbtSoltero.Text = "Soltero";
            this.rbtSoltero.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(50, 488);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 40);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Location = new System.Drawing.Point(189, 488);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 40);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir \r\nSin Guardar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.CalendarFont = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNac.Location = new System.Drawing.Point(67, 300);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNac.TabIndex = 4;
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtFem);
            this.gbxSexo.Controls.Add(this.rbtMasc);
            this.gbxSexo.Location = new System.Drawing.Point(50, 207);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(238, 53);
            this.gbxSexo.TabIndex = 3;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtFem
            // 
            this.rbtFem.AutoSize = true;
            this.rbtFem.Location = new System.Drawing.Point(129, 19);
            this.rbtFem.Name = "rbtFem";
            this.rbtFem.Size = new System.Drawing.Size(71, 17);
            this.rbtFem.TabIndex = 1;
            this.rbtFem.Text = "Femenino";
            this.rbtFem.UseVisualStyleBackColor = true;
            // 
            // rbtMasc
            // 
            this.rbtMasc.AutoSize = true;
            this.rbtMasc.Checked = true;
            this.rbtMasc.Location = new System.Drawing.Point(19, 19);
            this.rbtMasc.Name = "rbtMasc";
            this.rbtMasc.Size = new System.Drawing.Size(73, 17);
            this.rbtMasc.TabIndex = 0;
            this.rbtMasc.TabStop = true;
            this.rbtMasc.Text = "Masculino";
            this.rbtMasc.UseVisualStyleBackColor = true;
            // 
            // frmCargarPersona
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(324, 547);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbxEstadoCiv);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.tbxDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbxApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCargarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCargarPersona";
            this.Load += new System.EventHandler(this.frmCargarPersona_Load);
            this.gbxEstadoCiv.ResumeLayout(false);
            this.gbxEstadoCiv.PerformLayout();
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox tbxDni;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.GroupBox gbxEstadoCiv;
        private System.Windows.Forms.RadioButton rbtJuntado;
        private System.Windows.Forms.RadioButton rbtSeparado;
        private System.Windows.Forms.RadioButton rbtDivorciado;
        private System.Windows.Forms.RadioButton rbtCasado;
        private System.Windows.Forms.RadioButton rbtSoltero;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtFem;
        private System.Windows.Forms.RadioButton rbtMasc;
    }
}