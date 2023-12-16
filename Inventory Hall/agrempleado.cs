using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Hall
{
    public partial class agrempleado : Form
    {
        private BaseDeDatos basededatos;
        public agrempleado()
        {
            InitializeComponent();

          

        }

        private void agrempleado_Load(object sender, EventArgs e)
        {
            this.TopMost = true;

            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            txtdireccion.Enabled = false;
            mascaraDNI.Enabled = false;
            txtemail.Enabled = false;
            Mascaratelefono.Enabled = false;
            mascaracelular.Enabled = false;
            txtcargo.Enabled = false;

            txtnombre.BackColor = Color.Gray;
            txtapellido.BackColor = Color.Gray;
            txtdireccion.BackColor = Color.Gray;
            mascaraDNI.BackColor = Color.Gray;
            txtemail.BackColor = Color.Gray;
            Mascaratelefono.BackColor = Color.Gray;
            mascaracelular.BackColor = Color.Gray;
            txtcargo.BackColor = Color.Gray;
        }

        private void btnnuevo2_Click(object sender, EventArgs e)
        {
            txtnombre.Enabled = true;
            txtapellido.Enabled = true;
            txtdireccion.Enabled = true;
            mascaraDNI.Enabled = true;
            txtemail.Enabled = true;
            Mascaratelefono.Enabled = true;
            mascaracelular.Enabled = true;
            txtcargo.Enabled = true;

            txtnombre.BackColor = Color.White;
            txtapellido.BackColor = Color.White;
            txtdireccion.BackColor = Color.White;
            mascaraDNI.BackColor = Color.White;
            txtemail.BackColor = Color.White;
            Mascaratelefono.BackColor = Color.White;
            mascaracelular.BackColor = Color.White;
            txtcargo.BackColor = Color.White;
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
        private void btnguardar2_Click(object sender, EventArgs e)
        {
            try
            {


                string InsertarConsulta = "INSERT INTO empleado (nombre, apellido, direccion, dni, email, telefono, celular, cargo) " +
                   "VALUES (@nombre, @apellido, @direccion, @dni, @email, @telefono, @celular, @cargo)";

                if (string.IsNullOrWhiteSpace(txtnombre.Text) ||
                    string.IsNullOrWhiteSpace(txtapellido.Text) ||
                    string.IsNullOrWhiteSpace(txtdireccion.Text) ||
                    string.IsNullOrWhiteSpace(ObtenerTextoSinMascara(mascaraDNI)) ||
                    string.IsNullOrWhiteSpace(txtemail.Text) ||
                    string.IsNullOrWhiteSpace(ObtenerTextoSinMascara(Mascaratelefono)) ||
                    string.IsNullOrWhiteSpace(ObtenerTextoSinMascara(mascaracelular)) ||
                    string.IsNullOrWhiteSpace(txtcargo.Text))
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
                        command.Parameters.AddWithValue("@apellido", txtapellido.Text);
                        command.Parameters.AddWithValue("@direccion", txtdireccion.Text);

                        string dni = mascaraDNI.Text.Replace("-", " "); // Remove spaces or any other formatting
                        command.Parameters.AddWithValue("@dni", dni);

                        command.Parameters.AddWithValue("@email", txtemail.Text);

                        string numerodetelefono = Mascaratelefono.Text.Replace("-", ""); // Remove hyphens or any other formatting
                        command.Parameters.AddWithValue("@telefono", numerodetelefono);

                        string telefonocelular = mascaracelular.Text.Replace("-", ""); // Remove hyphens or any other formatting
                        command.Parameters.AddWithValue("@celular", telefonocelular);

                        command.Parameters.AddWithValue("@cargo", txtcargo.Text);

                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Data insertada correctamente.");

                    txtnombre.Clear();
                    txtapellido.Clear();
                    txtdireccion.Clear();
                    mascaraDNI.Clear();
                    txtemail.Clear();
                    Mascaratelefono.Clear();
                    mascaracelular.Clear();
                    txtcargo.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR HAS INSERTADO UN DATO MAL: " + ex.Message);
            }
        }
    }
}




