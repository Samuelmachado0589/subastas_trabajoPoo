using System.Windows.Forms;

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

            frmSubastas frmSubastas = frmSubastas.ventanaUnica();
            frmSubastas.BringToFront();

            frmSubastas.MdiParent = this;
            frmSubastas.Show();

        }



        private void resgistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSubastas frmSubastas = frmSubastas.ventanaUnica();
            frmSubastas.BringToFront();

            frmSubastas.MdiParent = this;
            frmSubastas.Show();
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestion frmGestion = new frmGestion();
            frmGestion.BringToFront();

            frmGestion.MdiParent = this;
            frmGestion.Show();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmMenu = this.ActiveMdiChild;

            if (frmMenu != null)
            {
                frmMenu.Close();
            }

        }

        private void cerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form frmMenu = this.ActiveMdiChild;

            if (frmMenu != null)
            {
                frmMenu.Close();
            }
        }

        private void cerrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Form frmMenu = this.ActiveMdiChild;

            if (frmMenu != null)
            {
                frmMenu.Close();
            }
        }
    }
}
