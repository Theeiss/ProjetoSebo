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
            this.components = new System.ComponentModel.Container();
            ProjetoSebo.controller.ProdutoController produtoController1 = new ProjetoSebo.controller.ProdutoController();
            ProjetoSebo.validator.ProdutoValidator produtoValidator1 = new ProjetoSebo.validator.ProdutoValidator();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnTestar = new System.Windows.Forms.Button();
            this.btnTestar2 = new System.Windows.Forms.Button();
            this.lblResultado2 = new System.Windows.Forms.Label();
            this.txtValor = new ProjetoSebo.views.components.TextBoxValor();
            this.txtData = new ProjetoSebo.views.components.TextBoxData();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtProduto = new ProjetoSebo.views.components.TextBoxProduto(this.components);
            this.btnBuscarProduto = new System.Windows.Forms.Button();
            this.lblResultadoProduto = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // btnTestar2
            // 
            this.btnTestar2.Location = new System.Drawing.Point(291, 130);
            this.btnTestar2.Name = "btnTestar2";
            this.btnTestar2.Size = new System.Drawing.Size(75, 23);
            this.btnTestar2.TabIndex = 6;
            this.btnTestar2.Text = "Testar";
            this.btnTestar2.UseVisualStyleBackColor = true;
            this.btnTestar2.Click += new System.EventHandler(this.BtnTestar2_Click);
            // 
            // lblResultado2
            // 
            this.lblResultado2.AutoSize = true;
            this.lblResultado2.Location = new System.Drawing.Point(399, 135);
            this.lblResultado2.Name = "lblResultado2";
            this.lblResultado2.Size = new System.Drawing.Size(55, 13);
            this.lblResultado2.TabIndex = 7;
            this.lblResultado2.Text = "Resultado";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(125, 130);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(135, 20);
            this.txtValor.TabIndex = 5;
            this.txtValor.Tipo = ProjetoSebo.views.components.TextBoxValor.TipoDado.dinheiro;
            this.txtValor.Valor = 0D;
            // 
            // txtData
            // 
            this.txtData.Data = new System.DateTime(((long)(0)));
            this.txtData.Location = new System.Drawing.Point(125, 60);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(142, 20);
            this.txtData.TabIndex = 4;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(125, 165);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(78, 266);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 9;
            this.lblProduto.Text = "Produto";
            // 
            // txtProduto
            // 
            this.txtProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Location = new System.Drawing.Point(128, 259);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Produto = null;
            produtoController1.Context = null;
            produtoController1.Tela = null;
            produtoController1.Validator = produtoValidator1;
            this.txtProduto.ProdutoController = produtoController1;
            this.txtProduto.Size = new System.Drawing.Size(209, 20);
            this.txtProduto.TabIndex = 10;
            this.txtProduto.Tipo = null;
            // 
            // btnBuscarProduto
            // 
            this.btnBuscarProduto.Location = new System.Drawing.Point(354, 257);
            this.btnBuscarProduto.Name = "btnBuscarProduto";
            this.btnBuscarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProduto.TabIndex = 11;
            this.btnBuscarProduto.Text = "Buscar";
            this.btnBuscarProduto.UseVisualStyleBackColor = true;
            this.btnBuscarProduto.Click += new System.EventHandler(this.BtnBuscarProduto_Click);
            // 
            // lblResultadoProduto
            // 
            this.lblResultadoProduto.AutoSize = true;
            this.lblResultadoProduto.Location = new System.Drawing.Point(469, 262);
            this.lblResultadoProduto.Name = "lblResultadoProduto";
            this.lblResultadoProduto.Size = new System.Drawing.Size(55, 13);
            this.lblResultadoProduto.TabIndex = 12;
            this.lblResultadoProduto.Text = "Resultado";
            // 
            // TelaTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultadoProduto);
            this.Controls.Add(this.btnBuscarProduto);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblResultado2);
            this.Controls.Add(this.btnTestar2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaTeste";
            this.Text = "TelaTeste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnTestar;
        private components.TextBoxData txtData;
        private components.TextBoxValor txtValor;
        private System.Windows.Forms.Button btnTestar2;
        private System.Windows.Forms.Label lblResultado2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblProduto;
        private components.TextBoxProduto txtProduto;
        private System.Windows.Forms.Button btnBuscarProduto;
        private System.Windows.Forms.Label lblResultadoProduto;
    }
}