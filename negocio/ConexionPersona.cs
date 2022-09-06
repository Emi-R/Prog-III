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

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader reader;

            try
            {
                conexion.ConnectionString = "server=localhost; database=AplicacionPersonas; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Dni, Apellido, Nombres, FechaNac, EstadoCivil, Sexo, Case When EstadoCivil = '1' Then 'Soltero' When EstadoCivil = '2' Then 'Casado'When EstadoCivil = '3' Then 'Divorciado' When EstadoCivil = '4' Then 'Separado' When EstadoCivil = '5' Then 'Juntado' End as EstadoCivil from Personas";
                comando.Connection = conexion;

                conexion.Open();
                reader = comando.ExecuteReader();

                while(reader.Read())
                {
                    Persona persona = new Persona();
                    persona.dni = (string)reader["Dni"];
                    persona.apellido = (string)reader["Apellido"];
                    persona.nombre = (string)reader["Nombres"];
                    persona.fechaNac = reader.GetDateTime(3);
                    persona.estadoCivil = reader.GetByte(4);
                    persona.sexo = reader.GetBoolean(5);

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

        public List<Persona> listarAsc()
        {
            List<Persona> lista = new List<Persona>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader reader;

            try
            {
                conexion.ConnectionString = "server=localhost; database=AplicacionPersonas; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select Dni, Apellido, Nombres, FechaNac, EstadoCivil, Sexo from Personas Order By Apellido Asc";
                comando.Connection = conexion;

                conexion.Open();
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Persona persona = new Persona();
                    persona.dni = (string)reader["Dni"];
                    persona.apellido = (string)reader["Apellido"];
                    persona.nombre = (string)reader["Nombres"];
                    persona.fechaNac = reader.GetDateTime(3);
                    persona.estadoCivil = reader.GetByte(4);
                    persona.sexo = reader.GetBoolean(5);

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
