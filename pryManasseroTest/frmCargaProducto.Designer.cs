namespace pryManasseroTest
{
    partial class frmCargaProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpOpciones = new System.Windows.Forms.GroupBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbRepuesto = new System.Windows.Forms.RadioButton();
            this.rbEnvio = new System.Windows.Forms.RadioButton();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.grpAdiconal = new System.Windows.Forms.GroupBox();
            this.rbInstalación = new System.Windows.Forms.RadioButton();
            this.rbGarantía = new System.Windows.Forms.RadioButton();
            this.rbEquipo = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.grpOpciones.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.grpAdiconal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Navy;
            this.lblNombre.Location = new System.Drawing.Point(28, 25);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Navy;
            this.btnRegistrar.Location = new System.Drawing.Point(410, 18);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(104, 35);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 23);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Items.AddRange(new object[] {
            "Notebook",
            "Teclado",
            "Impresora",
            "Mouse"});
            this.cmbProducto.Location = new System.Drawing.Point(239, 109);
            this.cmbProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(180, 28);
            this.cmbProducto.TabIndex = 3;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(28, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de productos";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.Navy;
            this.btnSiguiente.Location = new System.Drawing.Point(183, 178);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(135, 38);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Controls.Add(this.cmbProducto);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.ForeColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(22, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 284);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // grpOpciones
            // 
            this.grpOpciones.Controls.Add(this.grpAdiconal);
            this.grpOpciones.Controls.Add(this.grpTipo);
            this.grpOpciones.Controls.Add(this.comboBox1);
            this.grpOpciones.Controls.Add(this.lblProducto);
            this.grpOpciones.ForeColor = System.Drawing.Color.Navy;
            this.grpOpciones.Location = new System.Drawing.Point(22, 330);
            this.grpOpciones.Name = "grpOpciones";
            this.grpOpciones.Size = new System.Drawing.Size(518, 415);
            this.grpOpciones.TabIndex = 0;
            this.grpOpciones.TabStop = false;
            this.grpOpciones.Text = "-";
            this.grpOpciones.Visible = false;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.White;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.Navy;
            this.lblProducto.Location = new System.Drawing.Point(29, 58);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(96, 25);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Notebook",
            "Teclado",
            "Impresora",
            "Mouse"});
            this.comboBox1.Location = new System.Drawing.Point(183, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // rbRepuesto
            // 
            this.rbRepuesto.AutoSize = true;
            this.rbRepuesto.Location = new System.Drawing.Point(19, 30);
            this.rbRepuesto.Name = "rbRepuesto";
            this.rbRepuesto.Size = new System.Drawing.Size(122, 29);
            this.rbRepuesto.TabIndex = 7;
            this.rbRepuesto.TabStop = true;
            this.rbRepuesto.Text = "Repuesto";
            this.rbRepuesto.UseVisualStyleBackColor = true;
            // 
            // rbEnvio
            // 
            this.rbEnvio.AutoSize = true;
            this.rbEnvio.Location = new System.Drawing.Point(19, 87);
            this.rbEnvio.Name = "rbEnvio";
            this.rbEnvio.Size = new System.Drawing.Size(86, 29);
            this.rbEnvio.TabIndex = 8;
            this.rbEnvio.TabStop = true;
            this.rbEnvio.Text = "Envío";
            this.rbEnvio.UseVisualStyleBackColor = true;
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rbEquipo);
            this.grpTipo.Controls.Add(this.rbRepuesto);
            this.grpTipo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipo.Location = new System.Drawing.Point(33, 122);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(386, 100);
            this.grpTipo.TabIndex = 9;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo";
            // 
            // grpAdiconal
            // 
            this.grpAdiconal.Controls.Add(this.rbGarantía);
            this.grpAdiconal.Controls.Add(this.rbInstalación);
            this.grpAdiconal.Controls.Add(this.rbEnvio);
            this.grpAdiconal.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdiconal.Location = new System.Drawing.Point(33, 251);
            this.grpAdiconal.Name = "grpAdiconal";
            this.grpAdiconal.Size = new System.Drawing.Size(392, 140);
            this.grpAdiconal.TabIndex = 10;
            this.grpAdiconal.TabStop = false;
            this.grpAdiconal.Text = "Adicional";
            // 
            // rbInstalación
            // 
            this.rbInstalación.AutoSize = true;
            this.rbInstalación.Location = new System.Drawing.Point(19, 40);
            this.rbInstalación.Name = "rbInstalación";
            this.rbInstalación.Size = new System.Drawing.Size(134, 29);
            this.rbInstalación.TabIndex = 0;
            this.rbInstalación.TabStop = true;
            this.rbInstalación.Text = "Instalación";
            this.rbInstalación.UseVisualStyleBackColor = true;
            // 
            // rbGarantía
            // 
            this.rbGarantía.AutoSize = true;
            this.rbGarantía.Location = new System.Drawing.Point(177, 40);
            this.rbGarantía.Name = "rbGarantía";
            this.rbGarantía.Size = new System.Drawing.Size(113, 29);
            this.rbGarantía.TabIndex = 1;
            this.rbGarantía.TabStop = true;
            this.rbGarantía.Text = "Garantía";
            this.rbGarantía.UseVisualStyleBackColor = true;
            // 
            // rbEquipo
            // 
            this.rbEquipo.AutoSize = true;
            this.rbEquipo.Location = new System.Drawing.Point(177, 30);
            this.rbEquipo.Name = "rbEquipo";
            this.rbEquipo.Size = new System.Drawing.Size(100, 29);
            this.rbEquipo.TabIndex = 2;
            this.rbEquipo.TabStop = true;
            this.rbEquipo.Text = "Equipo";
            this.rbEquipo.UseVisualStyleBackColor = true;
            // 
            // frmCargaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(572, 757);
            this.Controls.Add(this.grpOpciones);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCargaProducto";
            this.Text = "frmCargaProducto";
            this.Load += new System.EventHandler(this.frmCargaProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpOpciones.ResumeLayout(false);
            this.grpOpciones.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.grpAdiconal.ResumeLayout(false);
            this.grpAdiconal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpOpciones;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rbEnvio;
        private System.Windows.Forms.RadioButton rbRepuesto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox grpAdiconal;
        private System.Windows.Forms.RadioButton rbGarantía;
        private System.Windows.Forms.RadioButton rbInstalación;
        private System.Windows.Forms.RadioButton rbEquipo;
    }
}