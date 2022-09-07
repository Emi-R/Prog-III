using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace negocio
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
            ConexionPersona negocio = new ConexionPersona();

            String estado;
            String sexo;

            //Carga y validacion de Apellido

            try
            {
            p.Apellido = tbxApellido.Text;

            p.Nombre = tbxNombre.Text;

            p.Dni = tbxDni.Text;

            if (rbtMasc.Checked)
            {
                p.Sexo = "M";
                sexo = "Masculino";
            }
            else
            {
                p.Sexo = "F";
                sexo = "Femenino";
            }

            p.FechaNac = dtpFechaNac.Value;

            if (rbtSoltero.Checked)
            {
                p.EstadoCivil = 1;
                estado = "Soltero";
            }
            else if (rbtCasado.Checked)
            {
                p.EstadoCivil = 2;
                estado = "Casado";
            }
            else if (rbtDivorciado.Checked)
            {
                p.EstadoCivil = 3;
                estado = "Divorciado";
            }
            else if (rbtSeparado.Checked)
            {
                p.EstadoCivil = 4;
                estado = "Separado";
            }
            else
            {
                p.EstadoCivil = 5;
                estado = "Juntado";
            }


            negocio.agregar(p);

            MessageBox.Show("Persona agregada correctamente. \n\nApellido y nombres: " + p.Apellido + ", " + p.Nombre + "\n" +
                            "DNI: " + p.Dni + "\n" +
                            "Sexo: " + sexo + "\n" +
                            "Fecha de Nacimiento: " + p.FechaNac.ToShortDateString() + "\n" +
                            "Estado civil: " + estado);
            }
            catch (Exception)
            {

                throw;
            }



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
