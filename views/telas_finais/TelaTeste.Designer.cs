namespace ProjetoSebo.views.telas_finais
{
    partial class TelaTeste
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
            this.txtValor = new ProjetoSebo.views.components.TextBoxValor();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnTestar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(125, 61);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(133, 20);
            this.txtValor.TabIndex = 0;
            this.txtValor.Tipo = ProjetoSebo.views.components.TextBoxValor.TipoDado.real;
            this.txtValor.Valor = 0D;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(78, 64);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(399, 64);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            // 
            // btnTestar
            // 
            this.btnTestar.Location = new System.Drawing.Point(291, 58);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(75, 23);
            this.btnTestar.TabIndex = 3;
            this.btnTestar.Text = "Testar";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.BtnTestar_Click);
            // 
            // TelaTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaTeste";
            this.Text = "TelaTeste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private components.TextBoxValor txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnTestar;
    }
}