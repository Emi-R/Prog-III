using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_CSharp_1
{
    internal class ConexionPersona
    {
        public List<Persona> listar()
        {
            List<Persona> lista = new List<Persona>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader reader;

            try
            {
                conexion.ConnectionString = "server=localhost; database=Personas; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select * From Personas";
                comando.Connection = conexion;

                conexion.Open();
                reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    Persona persona = new Persona();
                    persona.dni = reader.GetInt32(0);
                    persona.apellido = (string)reader["Apellido"];
                    persona.nombre = (string)reader["Nombre"];
                    persona.fechaNac = reader.GetDateTime(3);
                    persona.estadoCivil = reader.GetInt32(4);
                    persona.sexo = reader.GetString(5);

                    lista.Add(persona);

                }

                conexion.Close();

                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en base de datos.");
                throw ex;
            }

        }

    }
}
