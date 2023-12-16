using System.Diagnostics;

namespace Inventory_Hall
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación y detener la depuración
            Environment.Exit(0);

        }

        private void eNTRADAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrproducto agrproducto = new agrproducto();
            agrproducto.Show();


        }

        private void eMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrempleado agrempleado = new agrempleado();
            agrempleado.Show();
        }

        private void sUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                agrsuplidor agrsuplidor = new agrsuplidor();
                agrsuplidor.Show();
            }
        }

        private void dISTRIBUCIÓNDEARTICULOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            distribucioncategoria distribucioncategoria = new distribucioncategoria();
            distribucioncategoria.Show();
        }

        private void pRODUCTOToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            consultaproducto consultaproducto = new consultaproducto();
            consultaproducto.Show();
        }

        private void eMPLEADOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultaempleado consultaempleado = new consultaempleado();
            consultaempleado.Show();
        }

        private void sUPLIDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultasuplidor consultasuplidor = new Consultasuplidor();
            consultasuplidor.Show();
        }

        private void aCERCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ultimoacerca2 ultimoacerca2 = new ultimoacerca2();
            ultimoacerca2.Show();
        }

        private void aCERCADEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
    }
}