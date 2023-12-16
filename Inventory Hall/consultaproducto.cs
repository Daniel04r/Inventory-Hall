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
    public partial class consultaproducto : Form
    {
        private BaseDeDatos baseDeDatos;
        public consultaproducto()
        {
            InitializeComponent();
            baseDeDatos = new BaseDeDatos();
        }
        private void RealizarBusqueda()
        {
            {
                try
                {
                    // Obtener el término de búsqueda del cuadro de texto
                    string términoDeBúsqueda = txtID.Text.Trim();

                    // Verificar si el término de búsqueda no está vacío
                    if (!string.IsNullOrEmpty(términoDeBúsqueda))
                    {
                        // Determinar si el término de búsqueda es numérico para buscar por ID
                        if (int.TryParse(términoDeBúsqueda, out int idProducto))
                        {
                            // Buscar por ID
                            string consulta = "SELECT * FROM producto WHERE ID = @idProducto";

                            SqlParameter[] parametros =
                            {
                            new SqlParameter("@idProducto", idProducto)
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
                                dataGridproducto.DataSource = dataTable;
                            }
                        }
                        else
                        {
                            // Buscar por Nombre
                            string consulta = "SELECT * FROM producto WHERE Nombre LIKE @términoDeBúsqueda";

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
                                dataGridproducto.DataSource = dataTable;
                            }
                        }
                    }
                    else
                    {
                        // Si el término de búsqueda está vacío, recargar todos los productos
                        CargarProductos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void CargarProductos()
        {
            try
            {
                string consulta = "SELECT * FROM producto";

                DataTable dataTable = new DataTable();
                using (var adaptador = new SqlDataAdapter(consulta, baseDeDatos.ObtenerConexion()))
                {
                    adaptador.Fill(dataTable);
                }

                // Vincular el DataTable al DataGridView
                dataGridproducto.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void consultaproducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
            this.TopMost = true;
        }
    }
}

