using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class RepositorioMaestro : IRepositorioMaestro
    {
        public List<EPS> ObtenerEPS()
        {
            List<EPS> eps = new List<EPS>();
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["LigaNatacion"].ConnectionString))
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ConsultarEPS";
                comando.Connection = conexion;

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        eps.Add(new EPS()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = (string)reader["Nombre"]
                        });
                    }
                }
            }

            return eps;
        }

        public List<Disciplina> ObtenerDisciplinas()
        {
            List<Disciplina> disciplinas = new List<Disciplina>();
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["LigaNatacion"].ConnectionString))
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ConsultarDisciplinas";
                comando.Connection = conexion;

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        disciplinas.Add(new Disciplina()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = (string)reader["Nombre"]
                        });
                    }
                }
            }

            return disciplinas;
        }

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            List<TipoDocumento> tiposDocumento = new List<TipoDocumento>();
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["LigaNatacion"].ConnectionString))
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ConsultarTiposDocumento";
                comando.Connection = conexion;

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tiposDocumento.Add(new TipoDocumento()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = (string)reader["Nombre"]
                        });
                    }
                }
            }

            return tiposDocumento;
        }

        public List<Sexo> ObtenerSexo()
        {
            List<Sexo> sexo = new List<Sexo>();
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["LigaNatacion"].ConnectionString))
            {
                conexion.Open();

                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "ConsultarSexo";
                comando.Connection = conexion;

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sexo.Add(new Sexo()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Nombre = (string)reader["Nombre"]
                        });
                    }
                }
            }

            return sexo;
        }
    }
}
