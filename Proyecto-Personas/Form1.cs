using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace winform_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cargarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmCargarPersona))
                {
                    MessageBox.Show("Ya hay una ventana abierta esta opción");
                    return;
                }
            }

            frmCargarPersona ventanaCargarPersona = new frmCargarPersona();
            ventanaCargarPersona.MdiParent = this;
            ventanaCargarPersona.Show();

        }

        private void mostrarPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarPersonas frmMostrarPersonas = new frmMostrarPersonas();
            frmMostrarPersonas.MdiParent = this;
            frmMostrarPersonas.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMostrarPersonas frmMostrarPersonas = new frmMostrarPersonas();
            frmMostrarPersonas.MdiParent = this;
            frmMostrarPersonas.Show();
        }
    }
}
