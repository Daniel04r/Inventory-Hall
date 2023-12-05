using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Hall
{

    public partial class agrproducto : Form
    {
        public agrproducto()
        {
            InitializeComponent();

            ApartadoCategoria();



        }

        private void ApartadoCategoria()
        {
        
            String consulta = "SELECT id, tipo FROM categoria";


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

        }
    }
}




        