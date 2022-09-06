using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using dominio;


namespace negocio
{
    public class ConexionPersona
    {
        public List<Persona> listar()
        {
            List<Persona> lista = new List<Persona>();

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("Select Dni, Apellido, Nombres, FechaNac, EstadoCivil, Sexo From Personas");
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    Persona persona = new Persona();

                    persona.dni = (string)datos.Lector["Dni"];
                    persona.apellido = (string)datos.Lector["Apellido"];
                    persona.nombre = (string)datos.Lector["Nombres"];
                    persona.fechaNac = datos.Lector.GetDateTime(3);
                    persona.estadoCivil = datos.Lector.GetByte(4);
                    persona.sexo = datos.Lector.GetBoolean(5);

                    lista.Add(persona);

                }

                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
        
        public void agregar(Persona nueva)
        {

        }

        public void modificar (Persona modificar)
        {

        }
        


        

    }
}
