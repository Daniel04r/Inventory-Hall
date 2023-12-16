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
    public partial class distribucioncategoria : Form
    {
        private BaseDeDatos dbManager = new BaseDeDatos();
        private SqlConnection connection;
        public distribucioncategoria()
        {
            InitializeComponent();
        }

        private void distribucioncategoria_Load(object sender, EventArgs e)
        {
            {
                // Abrir la conexión a la base de datos
                connection = dbManager.ObtenerConexion();

                // TODO: Poblar el ComboBox con los IDs de productos desde la tabla "producto"
                string query = "SELECT id FROM producto";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBoxIDcategoria.Items.Add(reader["id"].ToString());
                    }
                }

                // TODO: Mostrar datos en el DataGridView
                RefreshDataGridView();
            }
        }

        private void RefreshDataGridView()
        {
            // Verificar si ya hay un DataReader abierto y cerrarlo
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            // Recuperar datos de la tabla "producto"
            string query = "SELECT * FROM producto";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Vincular el DataTable al DataGridView
                datagridcategoria.DataSource = dataTable;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Cerrar la conexión a la base de datos cuando se cierra el formulario
            dbManager.CerrarConexion();
            base.OnFormClosing(e);
        }

        private void comboBoxProductIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Puedes realizar acciones adicionales si es necesario
        }
    


private void btnactualizar_Click(object sender, EventArgs e)
        {
            {
                if (comboBoxIDcategoria.SelectedItem != null)
                {
                    string selectedProductID = comboBoxIDcategoria.SelectedItem.ToString();
                    string newSeccionValue = nuevasesion.Text;

                    // Verificar si el nuevo valor de sección está vacío
                    if (string.IsNullOrWhiteSpace(newSeccionValue))
                    {
                        MessageBox.Show("Favor elegir una seccion.");
                    }
                    else
                    {
                        // Actualizar la columna "seccion" en la tabla "producto"
                        string updateQuery = "UPDATE producto SET seccion = @newSeccion WHERE id = @productID";
                        SqlParameter[] parameters =
                        {
                        new SqlParameter("@newSeccion", newSeccionValue),
                        new SqlParameter("@productID", selectedProductID)
                    };

                        dbManager.EjecutarConsulta(updateQuery, parameters);

                        MessageBox.Show("Seccion Actualizada Con Exito.");

                        // Actualizar el DataGridView para mostrar los datos actualizados
                        RefreshDataGridView();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un ID de producto en el ComboBox.");
                }
            }
        }

        private void comboBoxIDcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
