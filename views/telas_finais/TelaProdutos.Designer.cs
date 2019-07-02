namespace ProjetoSebo.views.telas_finais
{
    partial class TelaProdutos
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.lblIdentificacaoTela = new System.Windows.Forms.Label();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.lblPalavrasChave = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cbxTipo = new ProjetoSebo.views.components.ComboTipoProduto(this.components);
            this.pnlLinhaPreco = new System.Windows.Forms.Panel();
            this.imgPreco = new System.Windows.Forms.PictureBox();
            this.cbxLocal = new System.Windows.Forms.ComboBox();
            this.pnlLinhaPalavrasChave = new System.Windows.Forms.Panel();
            this.pnlLinhaLocal = new System.Windows.Forms.Panel();
            this.pnlLinhaDescricao = new System.Windows.Forms.Panel();
            this.pnlLinhaCodigoBarras = new System.Windows.Forms.Panel();
            this.pnlLinhasTipo = new System.Windows.Forms.Panel();
            this.pnlLinhaQuantidade = new System.Windows.Forms.Panel();
            this.imgPalavraChave = new System.Windows.Forms.PictureBox();
            this.txtPalavrasChave = new System.Windows.Forms.TextBox();
            this.imgLocal = new System.Windows.Forms.PictureBox();
            this.imgQuantidade = new System.Windows.Forms.PictureBox();
            this.imgTipo = new System.Windows.Forms.PictureBox();
            this.imgCodBarras = new System.Windows.Forms.PictureBox();
            this.imgDescricao = new System.Windows.Forms.PictureBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPalavraChave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCodBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDescricao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.btnVoltar);
            this.pnlSuperior.Controls.Add(this.lblIdentificacaoTela);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(900, 80);
            this.pnlSuperior.TabIndex = 0;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Image = global::ProjetoSebo.Properties.Resources.voltar;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(32, 32);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // lblIdentificacaoTela
            // 
            this.lblIdentificacaoTela.AutoSize = true;
            this.lblIdentificacaoTela.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacaoTela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblIdentificacaoTela.Location = new System.Drawing.Point(102, 46);
            this.lblIdentificacaoTela.Name = "lblIdentificacaoTela";
            this.lblIdentificacaoTela.Size = new System.Drawing.Size(118, 31);
            this.lblIdentificacaoTela.TabIndex = 4;
            this.lblIdentificacaoTela.Text = "Produtos";
            // 
            // pnlDireita
            // 
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireita.Location = new System.Drawing.Point(800, 80);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(100, 570);
            this.pnlDireita.TabIndex = 1;
            // 
            // pnlInferior
            // 
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 570);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(800, 80);
            this.pnlInferior.TabIndex = 1;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 80);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(100, 490);
            this.pnlEsquerda.TabIndex = 1;
            // 
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.lblPalavrasChave);
            this.pnlCentral.Controls.Add(this.lblLocal);
            this.pnlCentral.Controls.Add(this.lblQuantidade);
            this.pnlCentral.Controls.Add(this.lblTipo);
            this.pnlCentral.Controls.Add(this.lblPreco);
            this.pnlCentral.Controls.Add(this.lblCodigoBarras);
            this.pnlCentral.Controls.Add(this.lblDescricao);
            this.pnlCentral.Controls.Add(this.cbxTipo);
            this.pnlCentral.Controls.Add(this.pnlLinhaPreco);
            this.pnlCentral.Controls.Add(this.imgPreco);
            this.pnlCentral.Controls.Add(this.cbxLocal);
            this.pnlCentral.Controls.Add(this.pnlLinhaPalavrasChave);
            this.pnlCentral.Controls.Add(this.pnlLinhaLocal);
            this.pnlCentral.Controls.Add(this.pnlLinhaDescricao);
            this.pnlCentral.Controls.Add(this.pnlLinhaCodigoBarras);
            this.pnlCentral.Controls.Add(this.pnlLinhasTipo);
            this.pnlCentral.Controls.Add(this.pnlLinhaQuantidade);
            this.pnlCentral.Controls.Add(this.imgPalavraChave);
            this.pnlCentral.Controls.Add(this.txtPalavrasChave);
            this.pnlCentral.Controls.Add(this.imgLocal);
            this.pnlCentral.Controls.Add(this.imgQuantidade);
            this.pnlCentral.Controls.Add(this.imgTipo);
            this.pnlCentral.Controls.Add(this.imgCodBarras);
            this.pnlCentral.Controls.Add(this.imgDescricao);
            this.pnlCentral.Controls.Add(this.txtQuantidade);
            this.pnlCentral.Controls.Add(this.txtCodBarras);
            this.pnlCentral.Controls.Add(this.txtDescricao);
            this.pnlCentral.Controls.Add(this.btnGravar);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(100, 80);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(700, 490);
            this.pnlCentral.TabIndex = 2;
            // 
            // lblPalavrasChave
            // 
            this.lblPalavrasChave.AutoSize = true;
            this.lblPalavrasChave.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavrasChave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblPalavrasChave.Location = new System.Drawing.Point(33, 377);
            this.lblPalavrasChave.Name = "lblPalavrasChave";
            this.lblPalavrasChave.Size = new System.Drawing.Size(104, 19);
            this.lblPalavrasChave.TabIndex = 49;
            this.lblPalavrasChave.Text = "Palavras-chave:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblLocal.Location = new System.Drawing.Point(33, 303);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(44, 19);
            this.lblLocal.TabIndex = 48;
            this.lblLocal.Text = "Local:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblQuantidade.Location = new System.Drawing.Point(434, 236);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(84, 19);
            this.lblQuantidade.TabIndex = 47;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblTipo.Location = new System.Drawing.Point(33, 162);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 19);
            this.lblTipo.TabIndex = 46;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblPreco.Location = new System.Drawing.Point(33, 236);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(47, 19);
            this.lblPreco.TabIndex = 45;
            this.lblPreco.Text = "Preço:";
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblCodigoBarras.Location = new System.Drawing.Point(33, 93);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(117, 19);
            this.lblCodigoBarras.TabIndex = 44;
            this.lblCodigoBarras.Text = "Código de Barras:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblDescricao.Location = new System.Drawing.Point(33, 26);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(72, 19);
            this.lblDescricao.TabIndex = 43;
            this.lblDescricao.Text = "Descrição:";
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
            this.cbxTipo.Location = new System.Drawing.Point(3, 186);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(300, 30);
            this.cbxTipo.TabIndex = 7;
            // 
            // pnlLinhaPreco
            // 
            this.pnlLinhaPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaPreco.Location = new System.Drawing.Point(1, 288);
            this.pnlLinhaPreco.Name = "pnlLinhaPreco";
            this.pnlLinhaPreco.Size = new System.Drawing.Size(300, 1);
            this.pnlLinhaPreco.TabIndex = 42;
            // 
            // imgPreco
            // 
            this.imgPreco.Image = global::ProjetoSebo.Properties.Resources.preco;
            this.imgPreco.Location = new System.Drawing.Point(0, 228);
            this.imgPreco.Name = "imgPreco";
            this.imgPreco.Size = new System.Drawing.Size(30, 30);
            this.imgPreco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPreco.TabIndex = 41;
            this.imgPreco.TabStop = false;
            // 
            // cbxLocal
            // 
            this.cbxLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLocal.BackColor = System.Drawing.SystemColors.Control;
            this.cbxLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxLocal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLocal.ForeColor = System.Drawing.Color.Black;
            this.cbxLocal.FormattingEnabled = true;
            this.cbxLocal.Location = new System.Drawing.Point(1, 327);
            this.cbxLocal.Name = "cbxLocal";
            this.cbxLocal.Size = new System.Drawing.Size(694, 29);
            this.cbxLocal.TabIndex = 10;
            this.cbxLocal.Tag = "";
            // 
            // pnlLinhaPalavrasChave
            // 
            this.pnlLinhaPalavrasChave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinhaPalavrasChave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaPalavrasChave.Location = new System.Drawing.Point(1, 429);
            this.pnlLinhaPalavrasChave.Name = "pnlLinhaPalavrasChave";
            this.pnlLinhaPalavrasChave.Size = new System.Drawing.Size(700, 1);
            this.pnlLinhaPalavrasChave.TabIndex = 37;
            // 
            // pnlLinhaLocal
            // 
            this.pnlLinhaLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinhaLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaLocal.Location = new System.Drawing.Point(1, 362);
            this.pnlLinhaLocal.Name = "pnlLinhaLocal";
            this.pnlLinhaLocal.Size = new System.Drawing.Size(700, 1);
            this.pnlLinhaLocal.TabIndex = 37;
            // 
            // pnlLinhaDescricao
            // 
            this.pnlLinhaDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinhaDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaDescricao.Location = new System.Drawing.Point(0, 78);
            this.pnlLinhaDescricao.Name = "pnlLinhaDescricao";
            this.pnlLinhaDescricao.Size = new System.Drawing.Size(700, 1);
            this.pnlLinhaDescricao.TabIndex = 37;
            // 
            // pnlLinhaCodigoBarras
            // 
            this.pnlLinhaCodigoBarras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinhaCodigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaCodigoBarras.Location = new System.Drawing.Point(0, 145);
            this.pnlLinhaCodigoBarras.Name = "pnlLinhaCodigoBarras";
            this.pnlLinhaCodigoBarras.Size = new System.Drawing.Size(700, 1);
            this.pnlLinhaCodigoBarras.TabIndex = 37;
            // 
            // pnlLinhasTipo
            // 
            this.pnlLinhasTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhasTipo.Location = new System.Drawing.Point(1, 221);
            this.pnlLinhasTipo.Name = "pnlLinhasTipo";
            this.pnlLinhasTipo.Size = new System.Drawing.Size(300, 1);
            this.pnlLinhasTipo.TabIndex = 37;
            // 
            // pnlLinhaQuantidade
            // 
            this.pnlLinhaQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaQuantidade.Location = new System.Drawing.Point(398, 287);
            this.pnlLinhaQuantidade.Name = "pnlLinhaQuantidade";
            this.pnlLinhaQuantidade.Size = new System.Drawing.Size(300, 1);
            this.pnlLinhaQuantidade.TabIndex = 36;
            // 
            // imgPalavraChave
            // 
            this.imgPalavraChave.Image = global::ProjetoSebo.Properties.Resources.palavras_chave;
            this.imgPalavraChave.Location = new System.Drawing.Point(0, 369);
            this.imgPalavraChave.Name = "imgPalavraChave";
            this.imgPalavraChave.Size = new System.Drawing.Size(30, 30);
            this.imgPalavraChave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPalavraChave.TabIndex = 35;
            this.imgPalavraChave.TabStop = false;
            // 
            // txtPalavrasChave
            // 
            this.txtPalavrasChave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPalavrasChave.BackColor = System.Drawing.SystemColors.Control;
            this.txtPalavrasChave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPalavrasChave.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavrasChave.ForeColor = System.Drawing.Color.Black;
            this.txtPalavrasChave.Location = new System.Drawing.Point(3, 401);
            this.txtPalavrasChave.Name = "txtPalavrasChave";
            this.txtPalavrasChave.Size = new System.Drawing.Size(695, 22);
            this.txtPalavrasChave.TabIndex = 11;
            // 
            // imgLocal
            // 
            this.imgLocal.Image = global::ProjetoSebo.Properties.Resources.local;
            this.imgLocal.Location = new System.Drawing.Point(0, 295);
            this.imgLocal.Name = "imgLocal";
            this.imgLocal.Size = new System.Drawing.Size(30, 30);
            this.imgLocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLocal.TabIndex = 33;
            this.imgLocal.TabStop = false;
            // 
            // imgQuantidade
            // 
            this.imgQuantidade.Image = global::ProjetoSebo.Properties.Resources.quantidade;
            this.imgQuantidade.Location = new System.Drawing.Point(401, 228);
            this.imgQuantidade.Name = "imgQuantidade";
            this.imgQuantidade.Size = new System.Drawing.Size(30, 30);
            this.imgQuantidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgQuantidade.TabIndex = 32;
            this.imgQuantidade.TabStop = false;
            // 
            // imgTipo
            // 
            this.imgTipo.Image = global::ProjetoSebo.Properties.Resources.tipo;
            this.imgTipo.Location = new System.Drawing.Point(0, 154);
            this.imgTipo.Name = "imgTipo";
            this.imgTipo.Size = new System.Drawing.Size(30, 30);
            this.imgTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTipo.TabIndex = 31;
            this.imgTipo.TabStop = false;
            // 
            // imgCodBarras
            // 
            this.imgCodBarras.Image = global::ProjetoSebo.Properties.Resources.codigo_barras;
            this.imgCodBarras.Location = new System.Drawing.Point(0, 85);
            this.imgCodBarras.Name = "imgCodBarras";
            this.imgCodBarras.Size = new System.Drawing.Size(30, 30);
            this.imgCodBarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCodBarras.TabIndex = 30;
            this.imgCodBarras.TabStop = false;
            // 
            // imgDescricao
            // 
            this.imgDescricao.Image = global::ProjetoSebo.Properties.Resources.descricao;
            this.imgDescricao.Location = new System.Drawing.Point(0, 18);
            this.imgDescricao.Name = "imgDescricao";
            this.imgDescricao.Size = new System.Drawing.Size(30, 30);
            this.imgDescricao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDescricao.TabIndex = 29;
            this.imgDescricao.TabStop = false;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.ForeColor = System.Drawing.Color.Black;
            this.txtQuantidade.Location = new System.Drawing.Point(401, 260);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(297, 22);
            this.txtQuantidade.TabIndex = 9;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodBarras.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodBarras.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarras.ForeColor = System.Drawing.Color.Black;
            this.txtCodBarras.Location = new System.Drawing.Point(3, 117);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(694, 22);
            this.txtCodBarras.TabIndex = 6;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtDescricao.Location = new System.Drawing.Point(3, 50);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(694, 22);
            this.txtDescricao.TabIndex = 5;
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
            this.btnGravar.TabIndex = 12;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // TelaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaProdutos";
            this.Text = "TelaProdutos";
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.pnlCentral.ResumeLayout(false);
            this.pnlCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPalavraChave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCodBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDescricao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.Label lblIdentificacaoTela;
        private System.Windows.Forms.PictureBox imgLocal;
        private System.Windows.Forms.PictureBox imgQuantidade;
        private System.Windows.Forms.PictureBox imgTipo;
        private System.Windows.Forms.PictureBox imgCodBarras;
        private System.Windows.Forms.PictureBox imgDescricao;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.PictureBox imgPalavraChave;
        private System.Windows.Forms.TextBox txtPalavrasChave;
        private System.Windows.Forms.Panel pnlLinhaPalavrasChave;
        private System.Windows.Forms.Panel pnlLinhaLocal;
        private System.Windows.Forms.Panel pnlLinhaDescricao;
        private System.Windows.Forms.Panel pnlLinhaCodigoBarras;
        private System.Windows.Forms.Panel pnlLinhasTipo;
        private System.Windows.Forms.Panel pnlLinhaQuantidade;
        private System.Windows.Forms.ComboBox cbxLocal;
        private System.Windows.Forms.Panel pnlLinhaPreco;
        private System.Windows.Forms.PictureBox imgPreco;
        private components.ComboTipoProduto cbxTipo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblPalavrasChave;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblCodigoBarras;
    }
}