namespace Exercicio_Cod_Barras
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mtxtPais = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEmpresa = new System.Windows.Forms.MaskedTextBox();
            this.mtxtProduto = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblControlo = new System.Windows.Forms.Label();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtxtPais
            // 
            this.mtxtPais.Location = new System.Drawing.Point(12, 53);
            this.mtxtPais.Mask = "000";
            this.mtxtPais.Name = "mtxtPais";
            this.mtxtPais.Size = new System.Drawing.Size(100, 20);
            this.mtxtPais.TabIndex = 0;
            this.mtxtPais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtEmpresa
            // 
            this.mtxtEmpresa.Location = new System.Drawing.Point(118, 53);
            this.mtxtEmpresa.Mask = "0000";
            this.mtxtEmpresa.Name = "mtxtEmpresa";
            this.mtxtEmpresa.Size = new System.Drawing.Size(100, 20);
            this.mtxtEmpresa.TabIndex = 1;
            this.mtxtEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxtProduto
            // 
            this.mtxtProduto.Location = new System.Drawing.Point(224, 53);
            this.mtxtProduto.Mask = "00000";
            this.mtxtProduto.Name = "mtxtProduto";
            this.mtxtProduto.Size = new System.Drawing.Size(100, 20);
            this.mtxtProduto.TabIndex = 2;
            this.mtxtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "País";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produto";
            // 
            // lblControlo
            // 
            this.lblControlo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControlo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblControlo.ForeColor = System.Drawing.Color.Red;
            this.lblControlo.Location = new System.Drawing.Point(344, 53);
            this.lblControlo.Name = "lblControlo";
            this.lblControlo.Size = new System.Drawing.Size(54, 20);
            this.lblControlo.TabIndex = 6;
            this.lblControlo.Text = "label4";
            this.lblControlo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigoBarras.Font = new System.Drawing.Font("EAN-13", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarras.Location = new System.Drawing.Point(85, 147);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(252, 106);
            this.lblCodigoBarras.TabIndex = 7;
            this.lblCodigoBarras.Text = "0000000000000";
            this.lblCodigoBarras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Controlo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Gerar Código";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 264);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCodigoBarras);
            this.Controls.Add(this.lblControlo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtxtProduto);
            this.Controls.Add(this.mtxtEmpresa);
            this.Controls.Add(this.mtxtPais);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Código de Barras EAN-13";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtPais;
        private System.Windows.Forms.MaskedTextBox mtxtEmpresa;
        private System.Windows.Forms.MaskedTextBox mtxtProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblControlo;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

