using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Inventory_Hall
{
    public class BaseDeDatos : IDisposable
    {
        private SqlConnection connection;

        public BaseDeDatos()
        {
            string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=inventoryhall;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            
        }

        public SqlConnection ObtenerConexion()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                return connection;
            }
            catch (Exception ex)
            {
                // Manejar la excepción de manera adecuada (por ejemplo, log, mostrar mensaje, etc.).
                throw new Exception("Error al abrir la conexión.", ex);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de manera adecuada (por ejemplo, log, mostrar mensaje, etc.).
                throw new Exception("Error al cerrar la conexión.", ex);
            }
        }

        public void EjecutarConsulta(string consulta, SqlParameter[] parametros = null)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(consulta, ObtenerConexion()))
                {
                    if (parametros != null)
                    {
                        command.Parameters.AddRange(parametros);
                    }

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción de manera adecuada (por ejemplo, log, mostrar mensaje, etc.).
                throw new Exception("Error al ejecutar la consulta.", ex);
            }
            finally
            {
                CerrarConexion();
            }
        }

        public void Dispose()
        {
            CerrarConexion();
            connection.Dispose();
        }
    }
}
