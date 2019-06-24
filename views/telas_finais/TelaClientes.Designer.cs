﻿namespace ProjetoSebo.views.telas_finais
{
    partial class TelaClientes
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
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pnlLinhaSexo = new System.Windows.Forms.Panel();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.imgSexo = new System.Windows.Forms.PictureBox();
            this.pnlLinhaDataNascimento = new System.Windows.Forms.Panel();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.imgDataNascimento = new System.Windows.Forms.PictureBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.pnlLinhaCpf = new System.Windows.Forms.Panel();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.imgCpf = new System.Windows.Forms.PictureBox();
            this.pnlLinhaNome = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdentificacaoTela = new System.Windows.Forms.Label();
            this.imgNome = new System.Windows.Forms.PictureBox();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDataNascimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCpf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNome)).BeginInit();
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
            // 
            // pnlDireita
            // 
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDireita.Location = new System.Drawing.Point(800, 80);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(100, 570);
            this.pnlDireita.TabIndex = 1;
            // 
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.pnlLinhaSexo);
            this.pnlCentral.Controls.Add(this.txtSexo);
            this.pnlCentral.Controls.Add(this.lblSexo);
            this.pnlCentral.Controls.Add(this.imgSexo);
            this.pnlCentral.Controls.Add(this.pnlLinhaDataNascimento);
            this.pnlCentral.Controls.Add(this.txtDataNascimento);
            this.pnlCentral.Controls.Add(this.lblDataNascimento);
            this.pnlCentral.Controls.Add(this.imgDataNascimento);
            this.pnlCentral.Controls.Add(this.btnGravar);
            this.pnlCentral.Controls.Add(this.pnlLinhaCpf);
            this.pnlCentral.Controls.Add(this.txtCpf);
            this.pnlCentral.Controls.Add(this.lblCpf);
            this.pnlCentral.Controls.Add(this.imgCpf);
            this.pnlCentral.Controls.Add(this.pnlLinhaNome);
            this.pnlCentral.Controls.Add(this.txtNome);
            this.pnlCentral.Controls.Add(this.lblNome);
            this.pnlCentral.Controls.Add(this.imgNome);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(0, 80);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(800, 570);
            this.pnlCentral.TabIndex = 1;
            // 
            // pnlLinhaSexo
            // 
            this.pnlLinhaSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaSexo.Location = new System.Drawing.Point(100, 360);
            this.pnlLinhaSexo.Name = "pnlLinhaSexo";
            this.pnlLinhaSexo.Size = new System.Drawing.Size(200, 2);
            this.pnlLinhaSexo.TabIndex = 41;
            // 
            // txtSexo
            // 
            this.txtSexo.BackColor = System.Drawing.SystemColors.Control;
            this.txtSexo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSexo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.ForeColor = System.Drawing.Color.Black;
            this.txtSexo.Location = new System.Drawing.Point(102, 332);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(200, 22);
            this.txtSexo.TabIndex = 48;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblSexo.Location = new System.Drawing.Point(133, 308);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(42, 19);
            this.lblSexo.TabIndex = 47;
            this.lblSexo.Text = "Sexo:";
            // 
            // imgSexo
            // 
            this.imgSexo.Image = global::ProjetoSebo.Properties.Resources.descricao;
            this.imgSexo.Location = new System.Drawing.Point(100, 300);
            this.imgSexo.Name = "imgSexo";
            this.imgSexo.Size = new System.Drawing.Size(30, 30);
            this.imgSexo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSexo.TabIndex = 46;
            this.imgSexo.TabStop = false;
            // 
            // pnlLinhaDataNascimento
            // 
            this.pnlLinhaDataNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaDataNascimento.Location = new System.Drawing.Point(100, 280);
            this.pnlLinhaDataNascimento.Name = "pnlLinhaDataNascimento";
            this.pnlLinhaDataNascimento.Size = new System.Drawing.Size(200, 2);
            this.pnlLinhaDataNascimento.TabIndex = 40;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.BackColor = System.Drawing.SystemColors.Control;
            this.txtDataNascimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDataNascimento.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimento.ForeColor = System.Drawing.Color.Black;
            this.txtDataNascimento.Location = new System.Drawing.Point(102, 252);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(200, 22);
            this.txtDataNascimento.TabIndex = 45;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblDataNascimento.Location = new System.Drawing.Point(133, 228);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(119, 19);
            this.lblDataNascimento.TabIndex = 44;
            this.lblDataNascimento.Text = "Data Nascimento:";
            // 
            // imgDataNascimento
            // 
            this.imgDataNascimento.Image = global::ProjetoSebo.Properties.Resources.descricao;
            this.imgDataNascimento.Location = new System.Drawing.Point(100, 220);
            this.imgDataNascimento.Name = "imgDataNascimento";
            this.imgDataNascimento.Size = new System.Drawing.Size(30, 30);
            this.imgDataNascimento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDataNascimento.TabIndex = 43;
            this.imgDataNascimento.TabStop = false;
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGravar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(57)))), ((int)(((byte)(90)))));
            this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(57)))), ((int)(((byte)(90)))));
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.White;
            this.btnGravar.Image = global::ProjetoSebo.Properties.Resources.salvar;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(599, 439);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(200, 50);
            this.btnGravar.TabIndex = 42;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // pnlLinhaCpf
            // 
            this.pnlLinhaCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaCpf.Location = new System.Drawing.Point(100, 199);
            this.pnlLinhaCpf.Name = "pnlLinhaCpf";
            this.pnlLinhaCpf.Size = new System.Drawing.Size(200, 2);
            this.pnlLinhaCpf.TabIndex = 39;
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.SystemColors.Control;
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.ForeColor = System.Drawing.Color.Black;
            this.txtCpf.Location = new System.Drawing.Point(102, 171);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(200, 22);
            this.txtCpf.TabIndex = 41;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblCpf.Location = new System.Drawing.Point(133, 147);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(36, 19);
            this.lblCpf.TabIndex = 40;
            this.lblCpf.Text = "CPF:";
            // 
            // imgCpf
            // 
            this.imgCpf.Image = global::ProjetoSebo.Properties.Resources.descricao;
            this.imgCpf.Location = new System.Drawing.Point(100, 139);
            this.imgCpf.Name = "imgCpf";
            this.imgCpf.Size = new System.Drawing.Size(30, 30);
            this.imgCpf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCpf.TabIndex = 39;
            this.imgCpf.TabStop = false;
            // 
            // pnlLinhaNome
            // 
            this.pnlLinhaNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinhaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaNome.Location = new System.Drawing.Point(100, 119);
            this.pnlLinhaNome.Name = "pnlLinhaNome";
            this.pnlLinhaNome.Size = new System.Drawing.Size(700, 2);
            this.pnlLinhaNome.TabIndex = 38;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.SystemColors.Control;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(102, 92);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(697, 22);
            this.txtNome.TabIndex = 37;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblNome.Location = new System.Drawing.Point(133, 69);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 19);
            this.lblNome.TabIndex = 36;
            this.lblNome.Text = "Nome:";
            // 
            // lblIdentificacaoTela
            // 
            this.lblIdentificacaoTela.AutoSize = true;
            this.lblIdentificacaoTela.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacaoTela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblIdentificacaoTela.Location = new System.Drawing.Point(102, 46);
            this.lblIdentificacaoTela.Name = "lblIdentificacaoTela";
            this.lblIdentificacaoTela.Size = new System.Drawing.Size(105, 31);
            this.lblIdentificacaoTela.TabIndex = 22;
            this.lblIdentificacaoTela.Text = "Clientes";
            // 
            // imgNome
            // 
            this.imgNome.Image = global::ProjetoSebo.Properties.Resources.descricao;
            this.imgNome.Location = new System.Drawing.Point(100, 61);
            this.imgNome.Name = "imgNome";
            this.imgNome.Size = new System.Drawing.Size(30, 30);
            this.imgNome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgNome.TabIndex = 35;
            this.imgNome.TabStop = false;
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
            // TelaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.pnlInferior);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaClientes";
            this.Text = "TelaClientes";
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.pnlCentral.ResumeLayout(false);
            this.pnlCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDataNascimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCpf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.Label lblIdentificacaoTela;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox imgNome;
        private System.Windows.Forms.Panel pnlLinhaNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel pnlLinhaCpf;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.PictureBox imgCpf;
        private System.Windows.Forms.Panel pnlLinhaSexo;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.PictureBox imgSexo;
        private System.Windows.Forms.Panel pnlLinhaDataNascimento;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.PictureBox imgDataNascimento;
        private System.Windows.Forms.Button btnGravar;
    }
}