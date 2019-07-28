namespace ProjetoSebo.views.telas_finais.inclusao
{
    partial class TelaVendas2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            ProjetoSebo.model.TipoProduto tipoProduto1 = new ProjetoSebo.model.TipoProduto();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblIdentificacaoTela = new System.Windows.Forms.Label();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tblListaCompras = new System.Windows.Forms.DataGridView();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlLinhaProduto = new System.Windows.Forms.Panel();
            this.pnlLinhaDesconto = new System.Windows.Forms.Panel();
            this.pnlLinhaQuantidade = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.textBoxValor4 = new ProjetoSebo.views.components.TextBoxValor();
            this.textBoxValor3 = new ProjetoSebo.views.components.TextBoxValor();
            this.textBoxValor2 = new ProjetoSebo.views.components.TextBoxValor();
            this.txtSubtotal = new ProjetoSebo.views.components.TextBoxValor();
            this.txtTotal = new ProjetoSebo.views.components.TextBoxValor();
            this.comboTipoProduto1 = new ProjetoSebo.views.components.ComboTipoProduto(this.components);
            this.pnlSuperior.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblListaCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.Controls.Add(this.lblIdentificacaoTela);
            this.pnlSuperior.Controls.Add(this.btnVoltar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(900, 80);
            this.pnlSuperior.TabIndex = 0;
            // 
            // lblIdentificacaoTela
            // 
            this.lblIdentificacaoTela.AutoSize = true;
            this.lblIdentificacaoTela.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacaoTela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblIdentificacaoTela.Location = new System.Drawing.Point(102, 45);
            this.lblIdentificacaoTela.Name = "lblIdentificacaoTela";
            this.lblIdentificacaoTela.Size = new System.Drawing.Size(98, 31);
            this.lblIdentificacaoTela.TabIndex = 6;
            this.lblIdentificacaoTela.Text = "Vendas";
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
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.btnImprimir);
            this.pnlCentral.Controls.Add(this.pnlLinhaQuantidade);
            this.pnlCentral.Controls.Add(this.pnlLinhaDesconto);
            this.pnlCentral.Controls.Add(this.pnlLinhaProduto);
            this.pnlCentral.Controls.Add(this.textBoxValor4);
            this.pnlCentral.Controls.Add(this.lblTotal);
            this.pnlCentral.Controls.Add(this.textBoxValor3);
            this.pnlCentral.Controls.Add(this.lblDesconto);
            this.pnlCentral.Controls.Add(this.textBoxValor2);
            this.pnlCentral.Controls.Add(this.txtSubtotal);
            this.pnlCentral.Controls.Add(this.lblSubtotal);
            this.pnlCentral.Controls.Add(this.txtTotal);
            this.pnlCentral.Controls.Add(this.lblQuantidade);
            this.pnlCentral.Controls.Add(this.lblProduto);
            this.pnlCentral.Controls.Add(this.comboTipoProduto1);
            this.pnlCentral.Controls.Add(this.lblTipo);
            this.pnlCentral.Controls.Add(this.tblListaCompras);
            this.pnlCentral.Controls.Add(this.btnVender);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(0, 80);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(800, 490);
            this.pnlCentral.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblTotal.Location = new System.Drawing.Point(643, 383);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 19);
            this.lblTotal.TabIndex = 60;
            this.lblTotal.Text = "Total:";
            // 
            // lblDesconto
            // 
            this.lblDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesconto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblDesconto.Location = new System.Drawing.Point(397, 344);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(71, 19);
            this.lblDesconto.TabIndex = 58;
            this.lblDesconto.Text = "Desconto:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblSubtotal.Location = new System.Drawing.Point(128, 344);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(64, 19);
            this.lblSubtotal.TabIndex = 55;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblQuantidade.Location = new System.Drawing.Point(537, 84);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(84, 19);
            this.lblQuantidade.TabIndex = 53;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblProduto.Location = new System.Drawing.Point(112, 85);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(62, 19);
            this.lblProduto.TabIndex = 52;
            this.lblProduto.Text = "Produto:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblTipo.Location = new System.Drawing.Point(109, 45);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 19);
            this.lblTipo.TabIndex = 50;
            this.lblTipo.Text = "Tipo:";
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
            this.tblListaCompras.Location = new System.Drawing.Point(102, 124);
            this.tblListaCompras.Name = "tblListaCompras";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tblListaCompras.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tblListaCompras.Size = new System.Drawing.Size(698, 200);
            this.tblListaCompras.TabIndex = 49;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 80);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(100, 490);
            this.pnlEsquerda.TabIndex = 1;
            // 
            // pnlLinhaProduto
            // 
            this.pnlLinhaProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaProduto.Location = new System.Drawing.Point(174, 107);
            this.pnlLinhaProduto.Name = "pnlLinhaProduto";
            this.pnlLinhaProduto.Size = new System.Drawing.Size(310, 1);
            this.pnlLinhaProduto.TabIndex = 42;
            // 
            // pnlLinhaDesconto
            // 
            this.pnlLinhaDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLinhaDesconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaDesconto.Location = new System.Drawing.Point(474, 365);
            this.pnlLinhaDesconto.Name = "pnlLinhaDesconto";
            this.pnlLinhaDesconto.Size = new System.Drawing.Size(100, 1);
            this.pnlLinhaDesconto.TabIndex = 62;
            // 
            // pnlLinhaQuantidade
            // 
            this.pnlLinhaQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaQuantidade.Location = new System.Drawing.Point(641, 107);
            this.pnlLinhaQuantidade.Name = "pnlLinhaQuantidade";
            this.pnlLinhaQuantidade.Size = new System.Drawing.Size(120, 1);
            this.pnlLinhaQuantidade.TabIndex = 63;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Control;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.btnImprimir.Image = global::ProjetoSebo.Properties.Resources.imprimir;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(102, 450);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(134, 37);
            this.btnImprimir.TabIndex = 64;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(57)))), ((int)(((byte)(90)))));
            this.btnVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(57)))), ((int)(((byte)(90)))));
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVender.ForeColor = System.Drawing.Color.White;
            this.btnVender.Image = global::ProjetoSebo.Properties.Resources.vender;
            this.btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVender.Location = new System.Drawing.Point(647, 440);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(153, 50);
            this.btnVender.TabIndex = 14;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Image = global::ProjetoSebo.Properties.Resources.voltar;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(32, 32);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.TabStop = false;
            // 
            // textBoxValor4
            // 
            this.textBoxValor4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValor4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValor4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValor4.Location = new System.Drawing.Point(691, 380);
            this.textBoxValor4.Name = "textBoxValor4";
            this.textBoxValor4.ReadOnly = true;
            this.textBoxValor4.Size = new System.Drawing.Size(100, 22);
            this.textBoxValor4.TabIndex = 61;
            this.textBoxValor4.Tipo = ProjetoSebo.views.components.TextBoxValor.TipoDado.dinheiro;
            this.textBoxValor4.Valor = 0D;
            // 
            // textBoxValor3
            // 
            this.textBoxValor3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxValor3.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxValor3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValor3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValor3.Location = new System.Drawing.Point(474, 341);
            this.textBoxValor3.Name = "textBoxValor3";
            this.textBoxValor3.Size = new System.Drawing.Size(100, 22);
            this.textBoxValor3.TabIndex = 59;
            this.textBoxValor3.Tipo = ProjetoSebo.views.components.TextBoxValor.TipoDado.dinheiro;
            this.textBoxValor3.Valor = 0D;
            // 
            // textBoxValor2
            // 
            this.textBoxValor2.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxValor2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValor2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValor2.Location = new System.Drawing.Point(641, 83);
            this.textBoxValor2.Name = "textBoxValor2";
            this.textBoxValor2.Size = new System.Drawing.Size(118, 22);
            this.textBoxValor2.TabIndex = 57;
            this.textBoxValor2.Tipo = ProjetoSebo.views.components.TextBoxValor.TipoDado.inteiro;
            this.textBoxValor2.Valor = 0D;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(198, 341);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 56;
            this.txtSubtotal.Tipo = ProjetoSebo.views.components.TextBoxValor.TipoDado.dinheiro;
            this.txtSubtotal.Valor = 0D;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(679, 1);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(112, 26);
            this.txtTotal.TabIndex = 54;
            this.txtTotal.Tipo = ProjetoSebo.views.components.TextBoxValor.TipoDado.dinheiro;
            this.txtTotal.Valor = 1D;
            // 
            // comboTipoProduto1
            // 
            this.comboTipoProduto1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboTipoProduto1.BackColor = System.Drawing.SystemColors.Control;
            this.comboTipoProduto1.DropDownWidth = 250;
            this.comboTipoProduto1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboTipoProduto1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoProduto1.FormattingEnabled = true;
            this.comboTipoProduto1.Location = new System.Drawing.Point(185, 40);
            this.comboTipoProduto1.Name = "comboTipoProduto1";
            this.comboTipoProduto1.Size = new System.Drawing.Size(300, 29);
            this.comboTipoProduto1.TabIndex = 51;
            tipoProduto1.Descricao = null;
            tipoProduto1.Id = 0;
            this.comboTipoProduto1.TipoProdutoSelecionado = tipoProduto1;
            // 
            // TelaVendas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaVendas2";
            this.Text = "TelaVendas2";
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            this.pnlCentral.ResumeLayout(false);
            this.pnlCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblListaCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label lblProduto;
        private components.ComboTipoProduto comboTipoProduto1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DataGridView tblListaCompras;
        private System.Windows.Forms.Label lblQuantidade;
        private components.TextBoxValor txtTotal;
        private components.TextBoxValor textBoxValor4;
        private System.Windows.Forms.Label lblTotal;
        private components.TextBoxValor textBoxValor3;
        private System.Windows.Forms.Label lblDesconto;
        private components.TextBoxValor textBoxValor2;
        private components.TextBoxValor txtSubtotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblIdentificacaoTela;
        private System.Windows.Forms.Panel pnlLinhaQuantidade;
        private System.Windows.Forms.Panel pnlLinhaDesconto;
        private System.Windows.Forms.Panel pnlLinhaProduto;
        private System.Windows.Forms.Button btnImprimir;
    }
}