namespace winform_app
{
    partial class Form1
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stpFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargarPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stpFechaHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(495, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stpFechaHora
            // 
            this.stpFechaHora.Name = "stpFechaHora";
            this.stpFechaHora.Size = new System.Drawing.Size(118, 17);
            this.stpFechaHora.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarPersonaToolStripMenuItem,
            this.mostrarPersonasToolStripMenuItem,
            this.buscarPersonasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cargarPersonaToolStripMenuItem
            // 
            this.cargarPersonaToolStripMenuItem.Name = "cargarPersonaToolStripMenuItem";
            this.cargarPersonaToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.cargarPersonaToolStripMenuItem.Text = "Cargar Nueva Persona";
            this.cargarPersonaToolStripMenuItem.Click += new System.EventHandler(this.cargarPersonaToolStripMenuItem_Click);
            // 
            // mostrarPersonasToolStripMenuItem
            // 
            this.mostrarPersonasToolStripMenuItem.Name = "mostrarPersonasToolStripMenuItem";
            this.mostrarPersonasToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.mostrarPersonasToolStripMenuItem.Text = "Mostrar Personas";
            this.mostrarPersonasToolStripMenuItem.Click += new System.EventHandler(this.mostrarPersonasToolStripMenuItem_Click);
            // 
            // buscarPersonasToolStripMenuItem
            // 
            this.buscarPersonasToolStripMenuItem.Name = "buscarPersonasToolStripMenuItem";
            this.buscarPersonasToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.buscarPersonasToolStripMenuItem.Text = "Buscar Personas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 473);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Personas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargarPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel stpFechaHora;
    }
}

