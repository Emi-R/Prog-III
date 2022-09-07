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
                datos.setearQuery("Select P.Dni, P.Apellido, P.Nombres, P.FechaNac, P.EstadoCivil, E.Estado, P.Sexo From Personas P, EstadoCivil_X_ID E Where P.EstadoCivil = E.ID");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Persona persona = new Persona();

                    persona.Dni = (string)datos.Lector["Dni"];
                    persona.Apellido = (string)datos.Lector["Apellido"];
                    persona.Nombre = (string)datos.Lector["Nombres"];
                    persona.FechaNac = datos.Lector.GetDateTime(3);
                    persona.EstadoCivil = datos.Lector.GetByte(4);
                    persona.Estado = datos.Lector.GetString(5);
                    persona.Sexo = (string)datos.Lector["Sexo"];


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
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearQuery("Insert into Personas Values ('" + nueva.Dni + "', '" +nueva.Apellido + "' , '" + nueva.Nombre + "' ,'" + nueva.FechaNac.ToShortDateString() + "'," + nueva.EstadoCivil + ", '" + nueva.Sexo + "')");

                datos.ejecutarNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void modificar(Persona modificar)
        {

        }





    }
}
