namespace subastas.pro
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        


        private void participacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSubastas frmSubastas = new frmSubastas();
        

            frmSubastas.BringToFront();
            frmSubastas.MdiParent = this;

            frmSubastas.Show();

        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }


        private void resgistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestion Registros = new frmGestion();


            Registros.BringToFront();

            Registros.MdiParent = this;
            Registros.Show();

        }

    }
}
