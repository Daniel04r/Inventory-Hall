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
    public partial class agrsuplidor : Form
    {
        private BaseDeDatos basededatos;
        public agrsuplidor()
        {
            InitializeComponent();
        }
        private string ObtenerTextoSinMascara(MaskedTextBox maskedTextBox)
        {
            string textoSinMascara = maskedTextBox.Text;
            foreach (char caracterMascara in maskedTextBox.Mask)
            {
                textoSinMascara = textoSinMascara.Replace(caracterMascara.ToString(), "");
            }
            return textoSinMascara;
        }
        private void btnnuevo3_Click(object sender, EventArgs e)
        {

            txtnombre.Enabled = true;
            txtemail.Enabled = true;
            mascararnc.Enabled = true;
            mascaratelefono.Enabled = true;
            txtdireccion.Enabled = true;
            txtdescripcion.Enabled = true;

            txtnombre.BackColor = Color.White;
            txtemail.BackColor = Color.White;
            mascararnc.BackColor = Color.White;
            mascaratelefono.BackColor = Color.White;
            txtdireccion.BackColor = Color.White;
            txtdescripcion.BackColor = Color.White;
        }

        private void agrsuplidor_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            {
                txtnombre.Enabled = false;
                txtemail.Enabled = false;
                mascararnc.Enabled = false;
                mascaratelefono.Enabled = false;
                txtdireccion.Enabled = false;
                txtdescripcion.Enabled = false;


                txtnombre.BackColor = Color.Gray;
                txtemail.BackColor = Color.Gray;
                mascararnc.BackColor = Color.Gray;
                mascaratelefono.BackColor = Color.Gray;
                txtdireccion.BackColor = Color.Gray;
                txtdescripcion.BackColor = Color.Gray;
            }
        }

        private void btnguardar3_Click(object sender, EventArgs e)
        {
            {
                string InsertarConsulta = "INSERT INTO suplidor (nombre, rnc, direccion, email, telefono, descripcion) " +
                                          "VALUES (@nombre, @rnc, @direccion, @email, @telefono, @descripcion)";
                try
                {
                    if (string.IsNullOrWhiteSpace(txtnombre.Text) ||
                        string.IsNullOrWhiteSpace(txtemail.Text) ||
                        string.IsNullOrWhiteSpace(ObtenerTextoSinMascara(mascararnc)) ||
                        string.IsNullOrWhiteSpace(ObtenerTextoSinMascara(mascaratelefono)) ||
                        string.IsNullOrWhiteSpace(txtdireccion.Text) ||
                        string.IsNullOrWhiteSpace(txtdescripcion.Text))
                    {
                        MessageBox.Show("Por favor completa todos los campos.");
                        return;
                    }

                    using (BaseDeDatos baseDeDatos = new BaseDeDatos())
                    {
                        baseDeDatos.ObtenerConexion();

                        using (SqlCommand command = new SqlCommand(InsertarConsulta, baseDeDatos.ObtenerConexion()))
                        {
                            command.Parameters.AddWithValue("@nombre", txtnombre.Text);
                            command.Parameters.AddWithValue("@email", txtemail.Text);
                            command.Parameters.AddWithValue("@direccion", txtdireccion.Text);

                            // Corrección en el nombre del parámetro
                            command.Parameters.AddWithValue("@descripcion", txtdescripcion.Text);

                            // No es necesario usar una variable intermedia para rnc
                            command.Parameters.AddWithValue("@rnc", mascararnc.Text.Replace("-", " "));

                            // No es necesario usar una variable intermedia para el teléfono
                            command.Parameters.AddWithValue("@telefono", mascaratelefono.Text.Replace("-", ""));

                            command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Data insertada correctamente.");

                        // Limpiar todos los campos después de la inserción exitosa
                        txtnombre.Clear();
                        txtemail.Clear();
                        txtdireccion.Clear();
                        mascararnc.Clear();
                        mascaratelefono.Clear();
                        txtdescripcion.Clear();
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar un mensaje más informativo sobre el error
                    MessageBox.Show("ERROR: Has insertado un dato incorrecto en el campo " + ex.Message);
                }
            }
        }
    }
}








