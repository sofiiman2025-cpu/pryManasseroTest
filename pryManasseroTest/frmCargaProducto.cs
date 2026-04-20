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
           

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese un nombre");
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Producto registrado");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (cmbProducto.Text == "")
            {
                MessageBox.Show("Ingrese el producto que desee");
                cmbProducto.Focus();
            }
            else
            {
                MessageBox.Show("Producto registrado con éxito");
            }
        }
    }
}
