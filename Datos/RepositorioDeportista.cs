using Entidades;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Datos
{
    public class RepositorioDeportista : IRepositorioDeportista
    {
        public static List<Deportista> deportistas = new List<Deportista>();

        public void EliminarDeportista(long idDeportista)
        {
            using (SqlConnection conexion =
               new SqlConnection(ConfigurationManager.
                   ConnectionStrings["LigaNatacion"].ConnectionString))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = conexion;

                comando.CommandText = "EliminarDeportista";
                comando.Parameters.Add("@IdDeportista", SqlDbType.BigInt).Value = idDeportista;

                comando.ExecuteNonQuery();
            }
        }

        public void IngresarDeportista(Deportista deportista)
        {
            using (SqlConnection conexion =
                new SqlConnection(ConfigurationManager.
                    ConnectionStrings["LigaNatacion"].ConnectionString))
            {
                conexion.Open();
                var transaction = conexion.BeginTransaction();

                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = conexion;
                comando.Transaction = transaction;

                comando.CommandText = "IngresarDeportista";
                comando.Parameters.Add("@PrimerNombre", SqlDbType.VarChar).Value = deportista.PrimerNombre;
                comando.Parameters.Add("@SegundoNombre", SqlDbType.VarChar).Value = deportista.SegundoNombre;
                comando.Parameters.Add("@PrimerApellido", SqlDbType.VarChar).Value = deportista.PrimerApellido;
                comando.Parameters.Add("@SegundoApellido", SqlDbType.VarChar).Value = deportista.SegundoApellido;
                comando.Parameters.Add("@CorreoElectronico", SqlDbType.VarChar).Value = deportista.CorreoElectronico;
                comando.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = deportista.Telefono;
                comando.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = deportista.Direccion;
                comando.Parameters.Add("@Documento", SqlDbType.BigInt).Value = deportista.NumeroDocumento;
                comando.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime).Value = deportista.FechaNacimiento;
                comando.Parameters.Add("@IdSexo", SqlDbType.SmallInt).Value = deportista.Sexo.Id;
                comando.Parameters.Add("@IdDisciplina", SqlDbType.SmallInt).Value = deportista.Disciplina.Id;
                comando.Parameters.Add("@IdTipoDocumento", SqlDbType.SmallInt).Value = deportista.TipoDocumento.Id;
                comando.Parameters.Add("@IdEPS", SqlDbType.SmallInt).Value = deportista.EPS.Id;
                comando.Parameters.Add("@IngresosMensuales", SqlDbType.SmallInt).Value = deportista.IngresosMensuales;

                comando.ExecuteNonQuery();

                transaction.Commit();
            }
        }

        public List<Deportista> ObtenerDeportistas(string numeroDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido)
        {
            List<Deportista> deportistas = new List<Deportista>();
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["LigaNatacion"].ConnectionString))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = conexion;
                comando.CommandText = "ConsultarDeportistas";
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Deportista deportista = new Deportista();
                        deportista.Id = Convert.ToInt64(reader["IdDeportista"]);
                        deportista.PrimerNombre = reader["PrimerNombre"].ToString();
                        deportista.SegundoNombre = reader["SegundoNombre"].ToString();
                        deportista.PrimerApellido = reader["PrimerApellido"].ToString();
                        deportista.SegundoApellido = reader["SegundoApellido"].ToString();
                        deportista.NumeroDocumento = reader["Documento"].ToString();
                        deportista.FechaNacimiento = (DateTime)reader["FechaNacimiento"];
                        deportista.Direccion = reader["Direccion"].ToString();
                        deportista.TipoDocumento = new TipoDocumento()
                        {
                            Id = Convert.ToInt32(reader["IdTipoDocumento"]),
                            Nombre = reader["NombreTipoDocumento"].ToString()
                        };

                        deportistas.Add(deportista);
                    }
                }
            }
            return deportistas;
        }

        public DataTable ObtenerDeportistas()
        {
            DataTable deportistas = new DataTable();
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["LigaNatacion"].ConnectionString))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Connection = conexion;
                comando.CommandText = "ConsultarDeportistas";

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(deportistas);
            }

            return deportistas;
        }
    }
}
