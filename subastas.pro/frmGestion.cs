using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace subastas.pro
{
    public partial class frmGestion : Form
    {
        public static frmSubastas Instancia = null;
        public static frmSubastas ventanaUnica()
        {
            if (Instancia == null)
            {
                Instancia = new frmSubastas();
            }
            return Instancia;
        }


        public List<object> ProductoNuevo = new List<object>();
        public List<object> DuracionNueva = new List<object>();

        public frmGestion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Producto = txtProductoNuevo.Text;
            ProductoNuevo.Add(Producto);
            string duracion = txtDuracionNueva.Text;
            DuracionNueva.Add(duracion);

            MessageBox.Show("se han guardado los datos");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtApellido.Text = "";
            txtDuracionNueva.Text = "";
            txtNombre.Text = "";
            txtProductoNuevo.Text = "";
        }
    }
}
