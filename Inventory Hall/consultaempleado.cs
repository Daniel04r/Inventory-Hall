using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Hall
{
    public partial class consultaempleado : Form
    {
        private readonly BaseDeDatos baseDeDatos;
        public consultaempleado()
        {
            InitializeComponent();
            baseDeDatos = new BaseDeDatos();
        }
        private void RealizarBusqueda()
        {
            try
            {
                // Obtener el término de búsqueda del cuadro de texto
                string términoDeBúsqueda = txtempleado.Text.Trim();

                // Verificar si el término de búsqueda no está vacío
                if (!string.IsNullOrEmpty(términoDeBúsqueda))
                {
                    // Determinar si el término de búsqueda es numérico para buscar por ID
                    if (int.TryParse(términoDeBúsqueda, out int idEmpleado))
                    {
                        // Buscar por ID
                        string consulta = "SELECT * FROM empleado WHERE ID = @idEmpleado";

                        SqlParameter[] parametros =
                        {
                            new SqlParameter("@idEmpleado", idEmpleado)
                        };

                        DataTable dataTable = new DataTable();
                        using (var adaptador = new SqlDataAdapter(consulta, baseDeDatos.ObtenerConexion()))
                        {
                            adaptador.SelectCommand.Parameters.AddRange(parametros);
                            adaptador.Fill(dataTable);
                        }

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("ID no existe");
                        }
                        else
                        {
                            // Vincular el DataTable al DataGridView
                            dataGridempleado.DataSource = dataTable;
                        }
                    }
                    else
                    {
                        // Buscar por Nombre
                        string consulta = "SELECT * FROM empleado WHERE Nombre LIKE @términoDeBúsqueda";

                        SqlParameter[] parametros =
                        {
                            new SqlParameter("@términoDeBúsqueda", "%" + términoDeBúsqueda + "%")
                        };

                        DataTable dataTable = new DataTable();
                        using (var adaptador = new SqlDataAdapter(consulta, baseDeDatos.ObtenerConexion()))
                        {
                            adaptador.SelectCommand.Parameters.AddRange(parametros);
                            adaptador.Fill(dataTable);
                        }

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Este nombre no está ingresado");
                        }
                        else
                        {
                            // Vincular el DataTable al DataGridView
                            dataGridempleado.DataSource = dataTable;
                        }
                    }
                }
                else
                {
                    // Si el término de búsqueda está vacío, recargar todos los empleados
                    CargarEmpleados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión en el bloque finally para asegurar que se cierre incluso si ocurre una excepción
                baseDeDatos.CerrarConexion();
            }
        }

        private void CargarEmpleados()
        {
            try
            {
                string consulta = "SELECT * FROM empleado";

                DataTable dataTable = new DataTable();
                using (var adaptador = new SqlDataAdapter(consulta, baseDeDatos.ObtenerConexion()))
                {
                    adaptador.Fill(dataTable);
                }

                // Vincular el DataTable al DataGridView
                dataGridempleado.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión en el bloque finally para asegurar que se cierre incluso si ocurre una excepción
                baseDeDatos.CerrarConexion();
            }
        }
        private void consultaempleado_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            this.TopMost = true;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }
    }
}
