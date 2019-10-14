namespace ProjetoSebo.views.telas_finais.consulta
{
    partial class TelaConsultaProdutos
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblIdentificacaoTela = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.tblProdutos = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutos)).BeginInit();
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
            this.lblIdentificacaoTela.Size = new System.Drawing.Size(242, 31);
            this.lblIdentificacaoTela.TabIndex = 26;
            this.lblIdentificacaoTela.Text = "Produtos - Consulta";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Image = global::ProjetoSebo.Properties.Resources.voltar;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(32, 32);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.TabStop = false;
            // 
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.tblProdutos);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(0, 80);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(900, 570);
            this.pnlCentral.TabIndex = 1;
            // 
            // tblProdutos
            // 
            this.tblProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnEditar,
            this.btnExcluir});
            this.tblProdutos.Location = new System.Drawing.Point(104, 3);
            this.tblProdutos.Name = "tblProdutos";
            this.tblProdutos.Size = new System.Drawing.Size(690, 481);
            this.tblProdutos.TabIndex = 0;
            this.tblProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblProdutos_CellContentClick);
            this.tblProdutos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.TblProdutos_DataBindingComplete);
            // 
            // btnEditar
            // 
            this.btnEditar.HeaderText = "";
            this.btnEditar.Image = global::ProjetoSebo.Properties.Resources.editar_tbl;
            this.btnEditar.Name = "btnEditar";
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "";
            this.btnExcluir.Image = global::ProjetoSebo.Properties.Resources.excluir_tbl;
            this.btnExcluir.Name = "btnExcluir";
            // 
            // pnlInferior
            // 
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(0, 570);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(900, 80);
            this.pnlInferior.TabIndex = 1;
            // 
            // pnlDireita
            // 
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireita.Location = new System.Drawing.Point(800, 80);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(100, 490);
            this.pnlDireita.TabIndex = 1;
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 80);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(100, 490);
            this.pnlEsquerda.TabIndex = 1;
            // 
            // TelaConsultaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaConsultaProdutos";
            this.Text = "TelaConsultaProdutos";
            this.Load += new System.EventHandler(this.TelaConsultaProdutos_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.pnlCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.Label lblIdentificacaoTela;
        private System.Windows.Forms.DataGridView tblProdutos;
        private System.Windows.Forms.DataGridViewImageColumn btnEditar;
        private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
    }
}