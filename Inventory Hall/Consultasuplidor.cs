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
    public partial class Consultasuplidor : Form
    {
        private BaseDeDatos baseDeDatos;

        public Consultasuplidor()
        {
            InitializeComponent();
            baseDeDatos = new BaseDeDatos();
        }

        private void RealizarBusqueda()
        {
            try
            {
                // Obtener el término de búsqueda del cuadro de texto
                string términoDeBúsqueda = txtidsuplidor.Text.Trim();

                // Verificar si el término de búsqueda no está vacío
                if (!string.IsNullOrEmpty(términoDeBúsqueda))
                {
                    // Determinar si el término de búsqueda es numérico para buscar por ID
                    if (int.TryParse(términoDeBúsqueda, out int idProveedor))
                    {
                        // Buscar por ID
                        string consulta = "SELECT * FROM suplidor WHERE ID = @idProveedor";

                        using (DataTable dataTable = new DataTable())
                        {
                            using (var adaptador = new SqlDataAdapter(consulta, baseDeDatos.ObtenerConexion()))
                            {
                                // Agregar parámetro para el ID del proveedor
                                adaptador.SelectCommand.Parameters.AddWithValue("@idProveedor", idProveedor);

                                // No necesitas abrir o cerrar la conexión manualmente con DataAdapter
                                //adapter.SelectCommand.Connection.Open();

                                int filasAfectadas = adaptador.Fill(dataTable);

                                // No necesitas cerrar la conexión manualmente con DataAdapter
                                //adapter.SelectCommand.Connection.Close();

                                if (filasAfectadas == 0)
                                {
                                    MessageBox.Show("Este ID no está ingresado");
                                }
                                else
                                {
                                    // Vincular la DataTable al DataGridView
                                    dataGrididsuplidor.DataSource = dataTable;
                                }
                            }
                        }
                    }
                    else
                    {
                        // Lógica para la búsqueda por RNC o Nombre (similar al código anterior)
                        // ...
                    }
                }
                else
                {
                    // Si el término de búsqueda está vacío, recargar todos los proveedores
                    CargarProveedores();
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

        private void CargarProveedores()
        {
            try
            {
                string consulta = "SELECT * FROM suplidor";

                using (DataTable dataTable = new DataTable())
                {
                    using (var adaptador = new SqlDataAdapter(consulta, baseDeDatos.ObtenerConexion()))
                    {
                        adaptador.Fill(dataTable);

                        // Vincular la DataTable al DataGridView
                        dataGrididsuplidor.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión cuando haya terminado
                baseDeDatos.CerrarConexion();
            }
        }

        private void Consultasuplidor_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            CargarProveedores();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            CargarProveedores();
        }
    }
}
