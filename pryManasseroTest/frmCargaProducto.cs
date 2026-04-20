using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryManasseroTest
{
    public partial class frmCargaProducto : Form
    {
        public frmCargaProducto()
        {
            InitializeComponent();
        }

        private void frmCargaProducto_Load(object sender, EventArgs e)
        {
            cmbProducto.Items.Add("Notebook");
            cmbProducto.Items.Add("PC Escritorio");
                cmbProducto.Items.Add("Impresora");
                cmbProducto.Items.Add("Scanner");

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Producto = cmbProducto.Text;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
