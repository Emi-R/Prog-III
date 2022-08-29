using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CSharp_1
{
    public partial class frmMostrarPersonas : Form
    {
        public frmMostrarPersonas()
        {
            InitializeComponent();
        }

        private void frmMostrarPersonas_Load(object sender, EventArgs e)
        {
            ConexionPersona conexion = new ConexionPersona();
            dgvPersonas.DataSource = conexion.listar();
        }
    }
}
