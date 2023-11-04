using System;
using System.CodeDom;
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
    public partial class frmloggin : Form
    {
        public frmloggin()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close(); //Esto es para cerrar el programa.
        }

        private void btnloggin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "jhondaniel" && mtxtcontrasena.Text == "jhondaniel")
            {
                principal principal = new principal();
                principal.Show();
                MessageBox.Show("Bienvenido al Sistema Inventory Hall");
                

            }
            else
            {
                if (txtUsuario.Text != "jhondaniel" && mtxtcontrasena.Text != "jhondaniel")
                {
                    MessageBox.Show("El usuario y la contraseña son incorrectas");
                }
                else if (txtUsuario.Text != "jhondaniel")
                {
                    MessageBox.Show("El usuario es incorrecto");
                }
                else if (mtxtcontrasena.Text != "jhondaniel")
                {
                    MessageBox.Show("La contraseña es incorrecta");
                }
            }


        
        }
    }
}
