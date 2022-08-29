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
                conexion.ConnectionString = "server=localhost; database=AplicacionPersonas; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Dni, Apellido, Nombre, FechaNac, EstadoCivil, Sexo from Personas";
                comando.Connection = conexion;

                conexion.Open();
                reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    Persona persona = new Persona();
                    persona.dni = (string)reader["Dni"];
                    persona.apellido = (string)reader["Apellido"];
                    persona.nombre = (string)reader["Nombre"];
                    persona.fechaNac = reader.GetDateTime(3);
                    persona.estadoCivil = reader.GetInt16(4);
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
