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

        }



        private void Llenarcategoria()
        {
            txtcategoria.Items.Clear();

            string consulta = "SELECT id, tipo FROM categoria";



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
            string InsertarConsulta = "INSERT INTO producto (nombre, categoria, descripcion, stock, idsuplidor, seccion) " +
                    "VALUES (@nombre, @categoria, @descripcion, @stock, @idsuplidor, @seccion)";

            if (string.IsNullOrWhiteSpace(txtnombre.Text) ||
                    txtcategoria.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtdescripcion.Text) ||
                    string.IsNullOrWhiteSpace(txtstock.Text) ||
                    txtidsuplidor.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(txtseccion.Text))
            {
                MessageBox.Show("Debes completar Todos los campos.");
                return;
            }

            try
            {
                using (BaseDeDatos baseDeDatos = new BaseDeDatos())
                {
                    baseDeDatos.ObtenerConexion();

                    using (SqlCommand command = new SqlCommand(InsertarConsulta, baseDeDatos.ObtenerConexion()))
                    {
                        // Asignar valores a los parámetros
                        command.Parameters.AddWithValue("@nombre", txtnombre.Text);
                        command.Parameters.AddWithValue("@categoria", Convert.ToInt32(txtcategoria.SelectedValue));
                        command.Parameters.AddWithValue("@descripcion", txtdescripcion.Text);
                        command.Parameters.AddWithValue("@stock", Convert.ToInt32(txtstock.Text));
                        command.Parameters.AddWithValue("@idsuplidor", Convert.ToInt32(txtidsuplidor.SelectedValue));
                        command.Parameters.AddWithValue("@seccion", txtseccion.Text);

                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        // Verificar si la inserción fue exitosa
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Inserción exitosa");
                        }
                        else
                        {
                            MessageBox.Show("La inserción no se realizó");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}




        