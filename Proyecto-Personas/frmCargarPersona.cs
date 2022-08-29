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
    public partial class frmCargarPersona : Form
    {
        public frmCargarPersona()
        {
            InitializeComponent();
        }

        private void frmCargarPersona_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            string estado;     

            p.apellido = tbxApellido.Text;
            p.nombre = tbxNombre.Text;
            p.dni = tbxDni.Text;
            p.fechaNac = dtpFechaNac.Value;


            if (rbtSoltero.Checked)
            {
                p.estadoCivil = 1;
                estado = "Soltero";
            }
            else if (rbtCasado.Checked)
            {
                p.estadoCivil = 2;
                estado = "Casado";
            }
            else if (rbtDivorciado.Checked)
            {
                p.estadoCivil = 3;
                estado = "Divorciado";
            }
            else if (rbtSeparado.Checked)
            {
                p.estadoCivil = 4;
                estado = "Separado";
            }   
            else
            {
                p.estadoCivil = 5;
                estado = "Juntado";
            }

            MessageBox.Show("Apellido y nombres: " + p.apellido + ", " + p.nombre + "\n\n" + 
                            "DNI: " + p.dni + "\n\n" +
                            "Fecha de Nacimiento: " + p.fechaNac.ToShortDateString() + "\n\n" +
                            "Estado civil: " + estado);

        }

    }
}
