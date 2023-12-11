using System;
using System.Collections;
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


    public partial class agrproducto : Form
    {
        private BaseDeDatos basededatos;
        public agrproducto()
        {
            InitializeComponent();

            basededatos = new BaseDeDatos();
            cargar_categoria();
            cargar_idsuplidor();

        }

        private void agrproducto_Load(object sender, EventArgs e)
        {
            txtnombre.Enabled = false;
            txtcategoria.Enabled = false;
            txtdescripcion.Enabled = false;
            txtstock.Enabled = false;
            txtidsuplidor.Enabled = false;
            txtseccion.Enabled = false;

            txtnombre.BackColor = Color.Gray;
            txtcategoria.BackColor = Color.Gray;
            txtdescripcion.BackColor = Color.Gray;
            txtstock.BackColor = Color.Gray;
            txtidsuplidor.BackColor = Color.Gray;
            txtseccion.BackColor = Color.Gray;

        }

        private void cargar_categoria()
        {

            // Utilizar un Dictionary para evitar duplicados
            Dictionary<string, bool> categoriasDic = new Dictionary<string, bool>();

            string query = "SELECT id, tipo FROM categoria";

            using (SqlCommand command = new SqlCommand(query, basededatos.ObtenerConexion()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string tipo = reader["tipo"].ToString();
                        string displayText = $"{id} - {tipo}";

                        // Agregar el elemento solo si no existe previamente en el Dictionary
                        if (!categoriasDic.ContainsKey(displayText))
                        {
                            categoriasDic.Add(displayText, true);
                            txtcategoria.Items.Add(displayText);

                        }
                    }
                }
            }
        }

        private void cargar_idsuplidor()
        {
            // Limpiar los elementos existentes en el ComboBox antes de cargar nuevamente
            txtidsuplidor.Items.Clear();

            // Utilizar un Dictionary para evitar duplicados
            Dictionary<string, bool> idsuplidorDic = new Dictionary<string, bool>();

            string query = "SELECT id, rnc FROM suplidor";

            using (SqlCommand command = new SqlCommand(query, basededatos.ObtenerConexion()))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        string id = reader["id"].ToString();
                        string displayText = $"{id}";

                        // Agregar el elemento solo si no existe previamente en el Dictionary
                        if (!idsuplidorDic.ContainsKey(displayText))
                        {
                            idsuplidorDic.Add(displayText, true);
                            txtidsuplidor.Items.Add(displayText);
                        }
                    }
                }
            }
        }

        private void txtcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void txtidsuplidor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;
            txtcategoria.Enabled = true;
            txtdescripcion.Enabled = true;
            txtstock.Enabled = true;
            txtidsuplidor.Enabled = true;
            txtseccion.Enabled = true;

            txtnombre.BackColor = Color.White;
            txtcategoria.BackColor = Color.White;
            txtdescripcion.BackColor = Color.White;
            txtstock.BackColor = Color.White;
            txtidsuplidor.BackColor = Color.White;
            txtseccion.BackColor = Color.White;

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string InsertarConsulta = "INSERT INTO producto (nombre, categoria, descripcion, stock, idsuplidor, seccion) " +
                        "VALUES (@nombre, @categoria, @descripcion, @stock, @idsuplidor, @seccion)";

                    if (string.IsNullOrWhiteSpace(txtnombre.Text) ||
                        txtcategoria.SelectedItem == null ||
                        string.IsNullOrWhiteSpace(txtdescripcion.Text) ||
                        string.IsNullOrWhiteSpace(txtstock.Text) ||
                        txtidsuplidor.SelectedItem == null ||
                        string.IsNullOrWhiteSpace(txtseccion.Text))
                    {
                        MessageBox.Show("Debes completar todos los campos.");
                        return;
                    }

                    if (!int.TryParse(txtstock.Text, out _))
                    {
                        MessageBox.Show("Favor introduzca un dato numérico en el campo Stock.");
                        return;
                    }

                    using (BaseDeDatos baseDeDatos = new BaseDeDatos())
                    {
                        baseDeDatos.ObtenerConexion();

                        using (SqlCommand command = new SqlCommand(InsertarConsulta, baseDeDatos.ObtenerConexion()))
                        {
                            command.Parameters.AddWithValue("@nombre", txtnombre.Text);
                            command.Parameters.AddWithValue("@categoria", txtcategoria.SelectedItem.ToString().Split(new[] { " - " }, StringSplitOptions.None)[0]);
                            command.Parameters.AddWithValue("@descripcion", txtdescripcion.Text);
                            command.Parameters.AddWithValue("@stock", txtstock.Text);
                            command.Parameters.AddWithValue("@idsuplidor", txtidsuplidor.SelectedItem.ToString().Split(new[] { " - " }, StringSplitOptions.None)[0]);
                            command.Parameters.AddWithValue("@seccion", txtseccion.Text);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Data insertada correctamente.");

                        txtcategoria.SelectedIndex = txtidsuplidor.SelectedIndex = -1;

                        txtnombre.Text = txtdescripcion.Text = txtstock.Text = txtseccion.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }
    }
}





