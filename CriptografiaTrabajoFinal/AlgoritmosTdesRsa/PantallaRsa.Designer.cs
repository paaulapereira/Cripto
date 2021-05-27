
namespace AlgoritmosTdesRsa
{
    partial class PantallaRsa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRsa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clavePubTxBox = new System.Windows.Forms.TextBox();
            this.claveTxBox = new System.Windows.Forms.TextBox();
            this.btnExportarClave = new System.Windows.Forms.Button();
            this.btnImportarClave = new System.Windows.Forms.Button();
            this.btnGenerarClave = new System.Windows.Forms.Button();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.btnExportarTxEncrip = new System.Windows.Forms.Button();
            this.btnImportarTxEncrip = new System.Windows.Forms.Button();
            this.txtEncriptadoTxBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.txtDesencriptadoTxBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Algoritmo de Encriptación RSA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clave Pública";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clave Privada";
            // 
            // clavePubTxBox
            // 
            this.clavePubTxBox.Location = new System.Drawing.Point(155, 57);
            this.clavePubTxBox.Name = "clavePubTxBox";
            this.clavePubTxBox.Size = new System.Drawing.Size(350, 20);
            this.clavePubTxBox.TabIndex = 4;
            // 
            // claveTxBox
            // 
            this.claveTxBox.Location = new System.Drawing.Point(155, 95);
            this.claveTxBox.Name = "claveTxBox";
            this.claveTxBox.Size = new System.Drawing.Size(350, 20);
            this.claveTxBox.TabIndex = 5;
            // 
            // btnExportarClave
            // 
            this.btnExportarClave.Location = new System.Drawing.Point(359, 132);
            this.btnExportarClave.Name = "btnExportarClave";
            this.btnExportarClave.Size = new System.Drawing.Size(145, 25);
            this.btnExportarClave.TabIndex = 8;
            this.btnExportarClave.Text = "Exportar Clave";
            this.btnExportarClave.UseVisualStyleBackColor = true;
            this.btnExportarClave.Click += new System.EventHandler(this.btnExportarClave_Click);
            // 
            // btnImportarClave
            // 
            this.btnImportarClave.Location = new System.Drawing.Point(187, 132);
            this.btnImportarClave.Name = "btnImportarClave";
            this.btnImportarClave.Size = new System.Drawing.Size(145, 25);
            this.btnImportarClave.TabIndex = 7;
            this.btnImportarClave.Text = "Importar Clave";
            this.btnImportarClave.UseVisualStyleBackColor = true;
            this.btnImportarClave.Click += new System.EventHandler(this.btnImportarClave_Click);
            // 
            // btnGenerarClave
            // 
            this.btnGenerarClave.Location = new System.Drawing.Point(14, 132);
            this.btnGenerarClave.Name = "btnGenerarClave";
            this.btnGenerarClave.Size = new System.Drawing.Size(145, 25);
            this.btnGenerarClave.TabIndex = 6;
            this.btnGenerarClave.Text = "Generar Clave";
            this.btnGenerarClave.UseVisualStyleBackColor = true;
            this.btnGenerarClave.Click += new System.EventHandler(this.btnGenerarClave_Click);
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.Location = new System.Drawing.Point(360, 539);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(145, 25);
            this.btnDesencriptar.TabIndex = 21;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = true;
            this.btnDesencriptar.Click += new System.EventHandler(this.btnDesencriptar_Click);
            // 
            // btnExportarTxEncrip
            // 
            this.btnExportarTxEncrip.Location = new System.Drawing.Point(303, 497);
            this.btnExportarTxEncrip.Name = "btnExportarTxEncrip";
            this.btnExportarTxEncrip.Size = new System.Drawing.Size(202, 25);
            this.btnExportarTxEncrip.TabIndex = 20;
            this.btnExportarTxEncrip.Text = "Exportar Texto Encriptado";
            this.btnExportarTxEncrip.UseVisualStyleBackColor = true;
            this.btnExportarTxEncrip.Click += new System.EventHandler(this.btnExportarTxEncrip_Click);
            // 
            // btnImportarTxEncrip
            // 
            this.btnImportarTxEncrip.Location = new System.Drawing.Point(15, 497);
            this.btnImportarTxEncrip.Name = "btnImportarTxEncrip";
            this.btnImportarTxEncrip.Size = new System.Drawing.Size(202, 25);
            this.btnImportarTxEncrip.TabIndex = 19;
            this.btnImportarTxEncrip.Text = "Importar Texto Encriptado";
            this.btnImportarTxEncrip.UseVisualStyleBackColor = true;
            this.btnImportarTxEncrip.Click += new System.EventHandler(this.btnImportarTxEncrip_Click);
            // 
            // txtEncriptadoTxBox
            // 
            this.txtEncriptadoTxBox.Location = new System.Drawing.Point(15, 387);
            this.txtEncriptadoTxBox.Name = "txtEncriptadoTxBox";
            this.txtEncriptadoTxBox.Size = new System.Drawing.Size(490, 93);
            this.txtEncriptadoTxBox.TabIndex = 18;
            this.txtEncriptadoTxBox.Text = "";
            this.txtEncriptadoTxBox.TextChanged += new System.EventHandler(this.txtEncriptadoTxBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Texto Encriptado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(15, 311);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(145, 25);
            this.btnEncriptar.TabIndex = 16;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // txtDesencriptadoTxBox
            // 
            this.txtDesencriptadoTxBox.Location = new System.Drawing.Point(15, 201);
            this.txtDesencriptadoTxBox.Name = "txtDesencriptadoTxBox";
            this.txtDesencriptadoTxBox.Size = new System.Drawing.Size(490, 93);
            this.txtDesencriptadoTxBox.TabIndex = 15;
            this.txtDesencriptadoTxBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Texto Desencriptado";
            // 
            // PantallaRsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(517, 580);
            this.Controls.Add(this.btnDesencriptar);
            this.Controls.Add(this.btnExportarTxEncrip);
            this.Controls.Add(this.btnImportarTxEncrip);
            this.Controls.Add(this.txtEncriptadoTxBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.txtDesencriptadoTxBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExportarClave);
            this.Controls.Add(this.btnImportarClave);
            this.Controls.Add(this.btnGenerarClave);
            this.Controls.Add(this.claveTxBox);
            this.Controls.Add(this.clavePubTxBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaRsa";
            this.Text = "Algoritmo RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clavePubTxBox;
        private System.Windows.Forms.TextBox claveTxBox;
        private System.Windows.Forms.Button btnExportarClave;
        private System.Windows.Forms.Button btnImportarClave;
        private System.Windows.Forms.Button btnGenerarClave;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.Button btnExportarTxEncrip;
        private System.Windows.Forms.Button btnImportarTxEncrip;
        private System.Windows.Forms.RichTextBox txtEncriptadoTxBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.RichTextBox txtDesencriptadoTxBox;
        private System.Windows.Forms.Label label5;
    }
}