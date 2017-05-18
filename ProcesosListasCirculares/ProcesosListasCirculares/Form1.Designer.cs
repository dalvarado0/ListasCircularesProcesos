namespace ProcesosListasCirculares
{
    partial class frmPrincipal
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
            this.btnSimular = new System.Windows.Forms.Button();
            this.txbResultados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(13, 14);
            this.btnSimular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(139, 35);
            this.btnSimular.TabIndex = 0;
            this.btnSimular.Text = "&Inicar Simulación";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // txbResultados
            // 
            this.txbResultados.Location = new System.Drawing.Point(13, 74);
            this.txbResultados.Multiline = true;
            this.txbResultados.Name = "txbResultados";
            this.txbResultados.Size = new System.Drawing.Size(309, 219);
            this.txbResultados.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AcceptButton = this.btnSimular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 346);
            this.Controls.Add(this.txbResultados);
            this.Controls.Add(this.btnSimular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox txbResultados;
    }
}

