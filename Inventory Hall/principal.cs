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
            this.Dispose();
        }

        private void eNTRADAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pRODUCTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agrproducto agrproducto = new agrproducto();
            agrproducto.Show();
        }
    }
}