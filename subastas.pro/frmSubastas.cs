using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace subastas.pro
{
    public partial class frmSubastas : Form
    {
        public frmSubastas()
        {
            InitializeComponent();

            cmbProducto.Items.Add("Carro");
            cmbProducto.Items.Add("Moto");
            cmbProducto.Items.Add("Avion");
            cmbProducto.Items.Add("bote");
            cmbProducto.Items.Add("bicicleta");

            cmbOferta.Items.Add("100.000");
            cmbOferta.Items.Add("200.000");
            cmbOferta.Items.Add("300.000");
            cmbOferta.Items.Add("400.000");
            cmbOferta.Items.Add("500.000");
            cmbOferta.Items.Add("6000.000");
            cmbOferta.Items.Add("700.000");
            cmbOferta.Items.Add("800.000");

            cmbDuracion.Items.Add("30:00");
            cmbDuracion.Items.Add("20:00");
            cmbDuracion.Items.Add("30:00");
            cmbDuracion.Items.Add("40:00");
            cmbDuracion.Items.Add("50:00");
            cmbDuracion.Items.Add("60:00");
            cmbDuracion.Items.Add("70:00");



        }
        public void deshabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Deshabilitar el GroupBox
            grbRegistros.Enabled = true;
        }

        List<object> nombreF = new List<object>();

        List<object> apellidoF = new List<object>();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            double telefono = Convert.ToDouble(txtTelefono.Text);
            double documento = Convert.ToDouble(txtDocumentos.Text);
            clsResgistros myRegistro = new clsResgistros(nombre, apellido, documento, telefono, email);


            dgvRegistros.Rows.Add(myRegistro.Nombre, myRegistro.Apellido, myRegistro.Documento, myRegistro.Telefono, myRegistro.Email);


            nombreF.Add($"{myRegistro.Nombre} ");
            apellidoF.Add(myRegistro.Apellido);
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtDocumentos.Text = "";

            cmbNombreF.Items.AddRange(nombreF.ToArray());
            cmbApellidoF.Items.AddRange(apellidoF.ToArray());

            foreach (var item in cmbNombreF.Items)
            {
                Console.WriteLine(item);
            }

            foreach (var item in cmbApellidoF.Items)
            {
                Console.WriteLine(item);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvRegistros.SelectedRows.Count > 0)
            {
                dgvRegistros.Rows.RemoveAt(dgvRegistros.SelectedRows[0].Index);

            }
            else
            {
                MessageBox.Show("Por favor sleccione una fila .");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCondicion.Text = ($"La oferta más alta en los próximos {cmbDuracion.SelectedItem.ToString()} minutos se lleva el artículo");
            string Producto = Convert.ToString(cmbProducto.SelectedItem);
            string NombreF = Convert.ToString(cmbNombreF.SelectedItem);
            string ApellidoF = Convert.ToString(cmbApellidoF.SelectedItem);
            double Oferta = Convert.ToDouble(cmbOferta.SelectedItem);
            string Duracion = Convert.ToString(cmbDuracion.SelectedItem);

            if (string.IsNullOrEmpty(Producto))
            {
                MessageBox.Show("elija un producto");
            }
            if (string.IsNullOrEmpty(NombreF))
            {
                MessageBox.Show("elija un Nombre");
            }
            if (Oferta == 0)
            {
                MessageBox.Show("elija un Nombre");
            }
             
            if (string.IsNullOrEmpty(Duracion))
            {
                MessageBox.Show("elija un Nombre");
            }
            else
            {
                dgvFinalSubasta.Rows.Add(Producto, NombreF, ApellidoF, Oferta, Duracion);
            }

            cmbApellidoF.SelectedItem = "";
            cmbNombreF.SelectedItem = "";
            cmbOferta.SelectedItem = "";
            cmbDuracion.SelectedItem = "";
            cmbOferta.SelectedItem = "";




        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* if (dgvFinalSubasta.Rows.Count > 0)
             {
                 // Obtiene el valor máximo en la columna especificada (columna 2 en este caso)
                 int maxValue = dgvFinalSubasta.Rows.Cast<DataGridViewRow>()
                                  .Max(row => Convert.ToInt32(row.Cells[3].Value));

                 // Busca la primera fila que tenga el valor máximo en la columna especificada
                 DataGridViewRow rowWithMaxValue = dgvFinalSubasta.Rows.Cast<DataGridViewRow>().FirstOrDefault(row => Convert.ToInt32(row.Cells[3].Value) == maxValue);

                 // Si se encuentra una fila con el valor máximo, selecciona esa fila
                 if (rowWithMaxValue != null)
                 {
                     rowWithMaxValue.Selected = true;
                 }

             }
            */
            if (dgvFinalSubasta.Rows.Count > 0)
            {
                // Obtiene el valor máximo en la columna especificada (columna 3 en este caso)
                int maxValue = dgvFinalSubasta.Rows.Cast<DataGridViewRow>()
                                 .Max(row => Convert.ToInt32(row.Cells[3].Value));

                // Busca la primera fila que tenga el valor máximo en la columna especificada
                DataGridViewRow rowWithMaxValue = dgvFinalSubasta.Rows.Cast<DataGridViewRow>().FirstOrDefault(row => Convert.ToInt32(row.Cells[3].Value) == maxValue);

                // Si se encuentra una fila con el valor máximo
                if (rowWithMaxValue != null)
                {
                    
                   
                        textBox1.Text = ( $"{dgvFinalSubasta.Columns[1].HeaderText}: {rowWithMaxValue.Cells[1].Value}\n \r\n" +
                        $"{dgvFinalSubasta.Columns[2].HeaderText}: {rowWithMaxValue.Cells[2].Value}\n \r\n " +
                        $"{dgvFinalSubasta.Columns[3].HeaderText}: {rowWithMaxValue.Cells[3].Value}\n \r\n");


                    pictureBox1.Visible = true;
                }
            }
        }
    }
}
