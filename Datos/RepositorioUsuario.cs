using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Datos
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        public Usuario ConsultarUsuario(string nombreUsuario)
        {
            Usuario usuario = null;
            SqlConnection conexion;
            SqlCommand comando;

            using (conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["LigaNatacion"].ConnectionString))
            {
                conexion.Open();
                comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = conexion;
                comando.CommandText = "ConsultarUsuario";
                comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombreUsuario;
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuario();
                        usuario.Clave = reader["Clave"].ToString();
                        usuario.Nombre = reader["Nombre"].ToString();
                    }
                }
            }

            return usuario;
        }
    }
}
