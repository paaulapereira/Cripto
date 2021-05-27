
namespace AlgoritmosTdesRsa
{
    partial class PantallaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicial));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTdes = new System.Windows.Forms.Button();
            this.btnRsa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escoja el algortimo que deseas utilizar:";
            // 
            // btnTdes
            // 
            this.btnTdes.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTdes.Location = new System.Drawing.Point(78, 72);
            this.btnTdes.Name = "btnTdes";
            this.btnTdes.Size = new System.Drawing.Size(94, 32);
            this.btnTdes.TabIndex = 1;
            this.btnTdes.Text = "TDES";
            this.btnTdes.UseVisualStyleBackColor = true;
            this.btnTdes.Click += new System.EventHandler(this.btnTdes_Click);
            // 
            // btnRsa
            // 
            this.btnRsa.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRsa.Location = new System.Drawing.Point(213, 72);
            this.btnRsa.Name = "btnRsa";
            this.btnRsa.Size = new System.Drawing.Size(94, 32);
            this.btnRsa.TabIndex = 2;
            this.btnRsa.Text = "RSA";
            this.btnRsa.UseVisualStyleBackColor = true;
            this.btnRsa.Click += new System.EventHandler(this.btnRsa_Click);
            // 
            // PantallaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(390, 146);
            this.Controls.Add(this.btnRsa);
            this.Controls.Add(this.btnTdes);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(406, 185);
            this.Name = "PantallaInicial";
            this.Text = "Algortimos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTdes;
        private System.Windows.Forms.Button btnRsa;
    }
}

