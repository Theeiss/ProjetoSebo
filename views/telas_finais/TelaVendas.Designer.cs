namespace ProjetoSebo.views.telas_finais
{
    partial class TelaVendas
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
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblListaCompras = new System.Windows.Forms.Label();
            this.tblListaCompras = new System.Windows.Forms.DataGridView();
            this.pnlLinhaDesconto = new System.Windows.Forms.Panel();
            this.imgDesconto = new System.Windows.Forms.PictureBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.pnlLinhaQuantidade = new System.Windows.Forms.Panel();
            this.imgQuantidade = new System.Windows.Forms.PictureBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.pnlLinhasTipo = new System.Windows.Forms.Panel();
            this.txtPreço = new System.Windows.Forms.TextBox();
            this.imgCodBarras = new System.Windows.Forms.PictureBox();
            this.pnlLinhaDescricao = new System.Windows.Forms.Panel();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.comboTipoProduto1 = new ProjetoSebo.views.components.ComboTipoProduto(this.components);
            this.lblIdentificacaoTela = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblListaCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCodBarras)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDireita
            // 
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireita.Location = new System.Drawing.Point(800, 0);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(100, 650);
            this.pnlDireita.TabIndex = 0;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.btnVoltar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(800, 80);
            this.pnlSuperior.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Image = global::ProjetoSebo.Properties.Resources.voltar;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(32, 32);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.TabStop = false;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 80);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(100, 570);
            this.pnlEsquerda.TabIndex = 1;
            // 
            // pnlInferior
            // 
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(100, 570);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(700, 80);
            this.pnlInferior.TabIndex = 1;
            // 
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.btnAdicionar);
            this.pnlCentral.Controls.Add(this.lblListaCompras);
            this.pnlCentral.Controls.Add(this.tblListaCompras);
            this.pnlCentral.Controls.Add(this.pnlLinhaDesconto);
            this.pnlCentral.Controls.Add(this.imgDesconto);
            this.pnlCentral.Controls.Add(this.txtDesconto);
            this.pnlCentral.Controls.Add(this.pnlLinhaQuantidade);
            this.pnlCentral.Controls.Add(this.imgQuantidade);
            this.pnlCentral.Controls.Add(this.txtQuantidade);
            this.pnlCentral.Controls.Add(this.pnlLinhasTipo);
            this.pnlCentral.Controls.Add(this.txtPreço);
            this.pnlCentral.Controls.Add(this.imgCodBarras);
            this.pnlCentral.Controls.Add(this.pnlLinhaDescricao);
            this.pnlCentral.Controls.Add(this.txtProduto);
            this.pnlCentral.Controls.Add(this.lblProduto);
            this.pnlCentral.Controls.Add(this.comboTipoProduto1);
            this.pnlCentral.Controls.Add(this.lblIdentificacaoTela);
            this.pnlCentral.Controls.Add(this.btnGravar);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(100, 80);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(700, 490);
            this.pnlCentral.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(57)))), ((int)(((byte)(90)))));
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(57)))), ((int)(((byte)(90)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Image = global::ProjetoSebo.Properties.Resources.adicionar;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionar.Location = new System.Drawing.Point(494, 223);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(200, 50);
            this.btnAdicionar.TabIndex = 50;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // lblListaCompras
            // 
            this.lblListaCompras.AutoSize = true;
            this.lblListaCompras.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblListaCompras.Location = new System.Drawing.Point(6, 259);
            this.lblListaCompras.Name = "lblListaCompras";
            this.lblListaCompras.Size = new System.Drawing.Size(141, 21);
            this.lblListaCompras.TabIndex = 49;
            this.lblListaCompras.Text = "Lista de Compras";
            // 
            // tblListaCompras
            // 
            this.tblListaCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblListaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblListaCompras.Location = new System.Drawing.Point(9, 283);
            this.tblListaCompras.Name = "tblListaCompras";
            this.tblListaCompras.Size = new System.Drawing.Size(685, 151);
            this.tblListaCompras.TabIndex = 48;
            // 
            // pnlLinhaDesconto
            // 
            this.pnlLinhaDesconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaDesconto.Location = new System.Drawing.Point(10, 223);
            this.pnlLinhaDesconto.Name = "pnlLinhaDesconto";
            this.pnlLinhaDesconto.Size = new System.Drawing.Size(300, 1);
            this.pnlLinhaDesconto.TabIndex = 47;
            // 
            // imgDesconto
            // 
            this.imgDesconto.Image = global::ProjetoSebo.Properties.Resources.desconto;
            this.imgDesconto.Location = new System.Drawing.Point(10, 185);
            this.imgDesconto.Name = "imgDesconto";
            this.imgDesconto.Size = new System.Drawing.Size(40, 40);
            this.imgDesconto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDesconto.TabIndex = 46;
            this.imgDesconto.TabStop = false;
            // 
            // txtDesconto
            // 
            this.txtDesconto.BackColor = System.Drawing.SystemColors.Control;
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.txtDesconto.Location = new System.Drawing.Point(56, 196);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(250, 22);
            this.txtDesconto.TabIndex = 45;
            this.txtDesconto.Text = "Desconto";
            // 
            // pnlLinhaQuantidade
            // 
            this.pnlLinhaQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaQuantidade.Location = new System.Drawing.Point(398, 168);
            this.pnlLinhaQuantidade.Name = "pnlLinhaQuantidade";
            this.pnlLinhaQuantidade.Size = new System.Drawing.Size(300, 1);
            this.pnlLinhaQuantidade.TabIndex = 44;
            // 
            // imgQuantidade
            // 
            this.imgQuantidade.Image = global::ProjetoSebo.Properties.Resources.quantidade;
            this.imgQuantidade.Location = new System.Drawing.Point(398, 130);
            this.imgQuantidade.Name = "imgQuantidade";
            this.imgQuantidade.Size = new System.Drawing.Size(40, 40);
            this.imgQuantidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgQuantidade.TabIndex = 43;
            this.imgQuantidade.TabStop = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.txtQuantidade.Location = new System.Drawing.Point(444, 141);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(250, 22);
            this.txtQuantidade.TabIndex = 42;
            this.txtQuantidade.Text = "Quantidade";
            // 
            // pnlLinhasTipo
            // 
            this.pnlLinhasTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhasTipo.Location = new System.Drawing.Point(9, 169);
            this.pnlLinhasTipo.Name = "pnlLinhasTipo";
            this.pnlLinhasTipo.Size = new System.Drawing.Size(300, 1);
            this.pnlLinhasTipo.TabIndex = 41;
            // 
            // txtPreço
            // 
            this.txtPreço.BackColor = System.Drawing.SystemColors.Control;
            this.txtPreço.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreço.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreço.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.txtPreço.Location = new System.Drawing.Point(55, 141);
            this.txtPreço.Name = "txtPreço";
            this.txtPreço.Size = new System.Drawing.Size(250, 22);
            this.txtPreço.TabIndex = 40;
            this.txtPreço.Text = "Preço";
            // 
            // imgCodBarras
            // 
            this.imgCodBarras.Image = global::ProjetoSebo.Properties.Resources.preco;
            this.imgCodBarras.Location = new System.Drawing.Point(9, 130);
            this.imgCodBarras.Name = "imgCodBarras";
            this.imgCodBarras.Size = new System.Drawing.Size(40, 40);
            this.imgCodBarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCodBarras.TabIndex = 39;
            this.imgCodBarras.TabStop = false;
            // 
            // pnlLinhaDescricao
            // 
            this.pnlLinhaDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinhaDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaDescricao.Location = new System.Drawing.Point(244, 107);
            this.pnlLinhaDescricao.Name = "pnlLinhaDescricao";
            this.pnlLinhaDescricao.Size = new System.Drawing.Size(450, 1);
            this.pnlLinhaDescricao.TabIndex = 38;
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProduto.BackColor = System.Drawing.SystemColors.Control;
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProduto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(244, 79);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(450, 22);
            this.txtProduto.TabIndex = 16;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblProduto.Location = new System.Drawing.Point(5, 55);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(72, 21);
            this.lblProduto.TabIndex = 15;
            this.lblProduto.Text = "Produto";
            // 
            // comboTipoProduto1
            // 
            this.comboTipoProduto1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboTipoProduto1.BackColor = System.Drawing.SystemColors.Control;
            this.comboTipoProduto1.DropDownWidth = 250;
            this.comboTipoProduto1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTipoProduto1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoProduto1.FormattingEnabled = true;
            this.comboTipoProduto1.Location = new System.Drawing.Point(9, 79);
            this.comboTipoProduto1.Name = "comboTipoProduto1";
            this.comboTipoProduto1.Size = new System.Drawing.Size(230, 29);
            this.comboTipoProduto1.TabIndex = 14;
            // 
            // lblIdentificacaoTela
            // 
            this.lblIdentificacaoTela.AutoSize = true;
            this.lblIdentificacaoTela.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacaoTela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblIdentificacaoTela.Location = new System.Drawing.Point(3, 2);
            this.lblIdentificacaoTela.Name = "lblIdentificacaoTela";
            this.lblIdentificacaoTela.Size = new System.Drawing.Size(98, 31);
            this.lblIdentificacaoTela.TabIndex = 5;
            this.lblIdentificacaoTela.Text = "Vendas";
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(57)))), ((int)(((byte)(90)))));
            this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(57)))), ((int)(((byte)(90)))));
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Image = global::ProjetoSebo.Properties.Resources.salvar;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(500, 440);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(200, 50);
            this.btnGravar.TabIndex = 13;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // TelaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.pnlDireita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaVendas";
            this.Text = "TelaVendas";
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.pnlCentral.ResumeLayout(false);
            this.pnlCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblListaCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCodBarras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblProduto;
        private components.ComboTipoProduto comboTipoProduto1;
        private System.Windows.Forms.Label lblIdentificacaoTela;
        private System.Windows.Forms.Panel pnlLinhaDescricao;
        private System.Windows.Forms.TextBox txtPreço;
        private System.Windows.Forms.PictureBox imgCodBarras;
        private System.Windows.Forms.Panel pnlLinhasTipo;
        private System.Windows.Forms.Panel pnlLinhaQuantidade;
        private System.Windows.Forms.PictureBox imgQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblListaCompras;
        private System.Windows.Forms.DataGridView tblListaCompras;
        private System.Windows.Forms.Panel pnlLinhaDesconto;
        private System.Windows.Forms.PictureBox imgDesconto;
        private System.Windows.Forms.TextBox txtDesconto;
    }
}