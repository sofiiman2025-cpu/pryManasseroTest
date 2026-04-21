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
            cmbProducto.Items.Add("Teclado");
            cmbProducto.Items.Add("Impresora");
            cmbProducto.Items.Add("Mouse");


        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese su nombre");           
                txtNombre.Focus();
            }
            else MessageBox.Show("Nombre registrado con éxito");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese su nombre");
                txtNombre.Focus();

            }
            if (cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto");
                cmbProducto.Focus();
            }

            else
            {
                MessageBox.Show("Producto registrado con éxito");

            }
            if (txtNombre.Text != "" && cmbProducto.SelectedIndex != -1)
            {
                grpOpciones.Visible = true;
            }
            lbRegistroIG.Text =  
                " - Nombre: " + txtNombre.Text + " - Producto: " + cmbProducto.Text;

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (rdbRepuesto.Checked || rdbEquipo.Checked)
            {
                string adicionales = "";

                if (rdbInstalación.Checked) adicionales += "Instalación ";
                if (rdbEnvio.Checked) adicionales += "Envío ";
                if (rdbGarantía.Checked) adicionales += "Garantía ";

                MessageBox.Show("Carga completa\nAdicionales: " + adicionales);
            }
            else
            {
                MessageBox.Show("Seleccione un tipo");
            }

        }
    }
}
