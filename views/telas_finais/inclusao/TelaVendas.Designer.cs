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
        protected override void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ProjetoSebo.controller.ProdutoController produtoController1 = new ProjetoSebo.controller.ProdutoController();
            ProjetoSebo.validator.ProdutoValidator produtoValidator1 = new ProjetoSebo.validator.ProdutoValidator();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            ProjetoSebo.bean.TipoProduto tipoProduto1 = new ProjetoSebo.bean.TipoProduto();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.lblIdentificacaoTela = new System.Windows.Forms.Label();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.txtProduto = new ProjetoSebo.views.components.TextBoxProduto(this.components);
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.imgProduto = new System.Windows.Forms.PictureBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.imgTipo = new System.Windows.Forms.PictureBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
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
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.imgPreco = new System.Windows.Forms.PictureBox();
            this.pnlLinhaDescricao = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbxTipo = new ProjetoSebo.views.components.ComboTipoProduto(this.components);
            this.btnGravar = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblListaCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDesconto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreco)).BeginInit();
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
            this.pnlSuperior.Controls.Add(this.lblIdentificacaoTela);
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
            // lblIdentificacaoTela
            // 
            this.lblIdentificacaoTela.AutoSize = true;
            this.lblIdentificacaoTela.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacaoTela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblIdentificacaoTela.Location = new System.Drawing.Point(102, 46);
            this.lblIdentificacaoTela.Name = "lblIdentificacaoTela";
            this.lblIdentificacaoTela.Size = new System.Drawing.Size(98, 31);
            this.lblIdentificacaoTela.TabIndex = 5;
            this.lblIdentificacaoTela.Text = "Vendas";
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
            this.pnlCentral.Controls.Add(this.txtProduto);
            this.pnlCentral.Controls.Add(this.lblQuantidade);
            this.pnlCentral.Controls.Add(this.imgProduto);
            this.pnlCentral.Controls.Add(this.lblProduto);
            this.pnlCentral.Controls.Add(this.imgTipo);
            this.pnlCentral.Controls.Add(this.lblDesconto);
            this.pnlCentral.Controls.Add(this.lblPreco);
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
            this.pnlCentral.Controls.Add(this.txtPreco);
            this.pnlCentral.Controls.Add(this.imgPreco);
            this.pnlCentral.Controls.Add(this.pnlLinhaDescricao);
            this.pnlCentral.Controls.Add(this.lblTipo);
            this.pnlCentral.Controls.Add(this.cbxTipo);
            this.pnlCentral.Controls.Add(this.btnGravar);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(100, 80);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(700, 490);
            this.pnlCentral.TabIndex = 1;
            // 
            // txtProduto
            // 
            this.txtProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProduto.BackColor = System.Drawing.SystemColors.Control;
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProduto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduto.Location = new System.Drawing.Point(267, 70);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Produto = null;
            produtoController1.Context = null;
            produtoController1.Tela = null;
            produtoController1.Validator = produtoValidator1;
            this.txtProduto.ProdutoController = produtoController1;
            this.txtProduto.Size = new System.Drawing.Size(430, 22);
            this.txtProduto.TabIndex = 57;
            this.txtProduto.Tipo = null;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblQuantidade.Location = new System.Drawing.Point(431, 113);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(84, 19);
            this.lblQuantidade.TabIndex = 56;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // imgProduto
            // 
            this.imgProduto.Image = global::ProjetoSebo.Properties.Resources.preco;
            this.imgProduto.Location = new System.Drawing.Point(267, 38);
            this.imgProduto.Name = "imgProduto";
            this.imgProduto.Size = new System.Drawing.Size(30, 30);
            this.imgProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProduto.TabIndex = 55;
            this.imgProduto.TabStop = false;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblProduto.Location = new System.Drawing.Point(300, 46);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(62, 19);
            this.lblProduto.TabIndex = 54;
            this.lblProduto.Text = "Produto:";
            // 
            // imgTipo
            // 
            this.imgTipo.Image = global::ProjetoSebo.Properties.Resources.tipo;
            this.imgTipo.Location = new System.Drawing.Point(0, 38);
            this.imgTipo.Name = "imgTipo";
            this.imgTipo.Size = new System.Drawing.Size(30, 30);
            this.imgTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTipo.TabIndex = 53;
            this.imgTipo.TabStop = false;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblDesconto.Location = new System.Drawing.Point(33, 188);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(71, 19);
            this.lblDesconto.TabIndex = 52;
            this.lblDesconto.Text = "Desconto:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblPreco.Location = new System.Drawing.Point(33, 113);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(47, 19);
            this.lblPreco.TabIndex = 51;
            this.lblPreco.Text = "Preço:";
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
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
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
            this.tblListaCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblListaCompras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(180)))), ((int)(((byte)(242)))));
            this.tblListaCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblListaCompras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblListaCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblListaCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblListaCompras.EnableHeadersVisualStyles = false;
            this.tblListaCompras.GridColor = System.Drawing.Color.SteelBlue;
            this.tblListaCompras.Location = new System.Drawing.Point(9, 283);
            this.tblListaCompras.Name = "tblListaCompras";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tblListaCompras.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tblListaCompras.Size = new System.Drawing.Size(685, 151);
            this.tblListaCompras.TabIndex = 48;
            // 
            // pnlLinhaDesconto
            // 
            this.pnlLinhaDesconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaDesconto.Location = new System.Drawing.Point(-46, 239);
            this.pnlLinhaDesconto.Name = "pnlLinhaDesconto";
            this.pnlLinhaDesconto.Size = new System.Drawing.Size(351, 1);
            this.pnlLinhaDesconto.TabIndex = 47;
            // 
            // imgDesconto
            // 
            this.imgDesconto.Image = global::ProjetoSebo.Properties.Resources.desconto;
            this.imgDesconto.Location = new System.Drawing.Point(0, 180);
            this.imgDesconto.Name = "imgDesconto";
            this.imgDesconto.Size = new System.Drawing.Size(30, 30);
            this.imgDesconto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDesconto.TabIndex = 46;
            this.imgDesconto.TabStop = false;
            // 
            // txtDesconto
            // 
            this.txtDesconto.BackColor = System.Drawing.SystemColors.Control;
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDesconto.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.ForeColor = System.Drawing.Color.Black;
            this.txtDesconto.Location = new System.Drawing.Point(2, 212);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(299, 22);
            this.txtDesconto.TabIndex = 45;
            // 
            // pnlLinhaQuantidade
            // 
            this.pnlLinhaQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaQuantidade.Location = new System.Drawing.Point(398, 164);
            this.pnlLinhaQuantidade.Name = "pnlLinhaQuantidade";
            this.pnlLinhaQuantidade.Size = new System.Drawing.Size(300, 1);
            this.pnlLinhaQuantidade.TabIndex = 44;
            // 
            // imgQuantidade
            // 
            this.imgQuantidade.Image = global::ProjetoSebo.Properties.Resources.quantidade;
            this.imgQuantidade.Location = new System.Drawing.Point(398, 105);
            this.imgQuantidade.Name = "imgQuantidade";
            this.imgQuantidade.Size = new System.Drawing.Size(30, 30);
            this.imgQuantidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgQuantidade.TabIndex = 43;
            this.imgQuantidade.TabStop = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.ForeColor = System.Drawing.Color.Black;
            this.txtQuantidade.Location = new System.Drawing.Point(398, 137);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(300, 22);
            this.txtQuantidade.TabIndex = 42;
            // 
            // pnlLinhasTipo
            // 
            this.pnlLinhasTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhasTipo.Location = new System.Drawing.Point(1, 165);
            this.pnlLinhasTipo.Name = "pnlLinhasTipo";
            this.pnlLinhasTipo.Size = new System.Drawing.Size(300, 1);
            this.pnlLinhasTipo.TabIndex = 41;
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.SystemColors.Control;
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.Color.Black;
            this.txtPreco.Location = new System.Drawing.Point(2, 137);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(299, 22);
            this.txtPreco.TabIndex = 40;
            // 
            // imgPreco
            // 
            this.imgPreco.Image = global::ProjetoSebo.Properties.Resources.preco;
            this.imgPreco.Location = new System.Drawing.Point(0, 105);
            this.imgPreco.Name = "imgPreco";
            this.imgPreco.Size = new System.Drawing.Size(30, 30);
            this.imgPreco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPreco.TabIndex = 39;
            this.imgPreco.TabStop = false;
            // 
            // pnlLinhaDescricao
            // 
            this.pnlLinhaDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinhaDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaDescricao.Location = new System.Drawing.Point(267, 98);
            this.pnlLinhaDescricao.Name = "pnlLinhaDescricao";
            this.pnlLinhaDescricao.Size = new System.Drawing.Size(430, 1);
            this.pnlLinhaDescricao.TabIndex = 38;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblTipo.Location = new System.Drawing.Point(33, 46);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 19);
            this.lblTipo.TabIndex = 15;
            this.lblTipo.Text = "Tipo:";
            // 
            // cbxTipo
            // 
            this.cbxTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxTipo.BackColor = System.Drawing.SystemColors.Control;
            this.cbxTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTipo.DropDownWidth = 250;
            this.cbxTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTipo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(0, 70);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(239, 30);
            this.cbxTipo.TabIndex = 14;
            tipoProduto1.Descricao = null;
            tipoProduto1.Id = 0;
            this.cbxTipo.TipoProdutoSelecionado = tipoProduto1;
            this.cbxTipo.Leave += new System.EventHandler(this.CbxTipo_Leave);
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
            this.Load += new System.EventHandler(this.TelaVendas_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.pnlCentral.ResumeLayout(false);
            this.pnlCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblListaCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDesconto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreco)).EndInit();
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
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblIdentificacaoTela;
        private System.Windows.Forms.Panel pnlLinhaDescricao;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.PictureBox imgPreco;
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
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.PictureBox imgTipo;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.PictureBox imgProduto;
        private System.Windows.Forms.Label lblProduto;
        private components.ComboTipoProduto cbxTipo;
        private components.TextBoxProduto txtProduto;
    }
}