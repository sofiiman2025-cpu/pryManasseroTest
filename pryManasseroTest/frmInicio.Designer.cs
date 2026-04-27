namespace pryManasseroTest
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.picSistema = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // picSistema
            // 
            this.picSistema.BackColor = System.Drawing.Color.MidnightBlue;
            this.picSistema.Image = global::pryManasseroTest.Properties.Resources.descarga;
            this.picSistema.Location = new System.Drawing.Point(34, 21);
            this.picSistema.Name = "picSistema";
            this.picSistema.Size = new System.Drawing.Size(233, 174);
            this.picSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSistema.TabIndex = 0;
            this.picSistema.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnIniciar.Location = new System.Drawing.Point(113, 201);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 27);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(301, 251);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.picSistema);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.picSistema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSistema;
        private System.Windows.Forms.Button btnIniciar;
    }
}

