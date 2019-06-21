namespace ProjetoSebo.views
{
    partial class TelaUsuariosCadastro
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
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlInferior = new System.Windows.Forms.Panel();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgCodBarras = new System.Windows.Forms.PictureBox();
            this.lblIdentificacaoTela = new System.Windows.Forms.Label();
            this.pnlLinhaConfirmarSenha = new System.Windows.Forms.Panel();
            this.pnlLinhaSenha = new System.Windows.Forms.Panel();
            this.pnlLinhaLogin = new System.Windows.Forms.Panel();
            this.imgFoto = new System.Windows.Forms.PictureBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCodBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
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
            this.btnVoltar.Image = global::ProjetoSebo.Properties.Resources.voltar;
            this.btnVoltar.Location = new System.Drawing.Point(16, 15);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(32, 32);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // pnlEsquerda
            // 
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Location = new System.Drawing.Point(0, 80);
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Size = new System.Drawing.Size(100, 570);
            this.pnlEsquerda.TabIndex = 2;
            // 
            // pnlInferior
            // 
            this.pnlInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInferior.Location = new System.Drawing.Point(100, 570);
            this.pnlInferior.Name = "pnlInferior";
            this.pnlInferior.Size = new System.Drawing.Size(700, 80);
            this.pnlInferior.TabIndex = 3;
            // 
            // pnlCentral
            // 
            this.pnlCentral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCentral.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCentral.Controls.Add(this.pictureBox2);
            this.pnlCentral.Controls.Add(this.pictureBox1);
            this.pnlCentral.Controls.Add(this.imgCodBarras);
            this.pnlCentral.Controls.Add(this.lblIdentificacaoTela);
            this.pnlCentral.Controls.Add(this.pnlLinhaConfirmarSenha);
            this.pnlCentral.Controls.Add(this.pnlLinhaSenha);
            this.pnlCentral.Controls.Add(this.pnlLinhaLogin);
            this.pnlCentral.Controls.Add(this.imgFoto);
            this.pnlCentral.Controls.Add(this.txtConfirmarSenha);
            this.pnlCentral.Controls.Add(this.txtSenha);
            this.pnlCentral.Controls.Add(this.txtLogin);
            this.pnlCentral.Controls.Add(this.btnGravar);
            this.pnlCentral.Location = new System.Drawing.Point(100, 80);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(700, 490);
            this.pnlCentral.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoSebo.Properties.Resources.codigo_barras;
            this.pictureBox2.Location = new System.Drawing.Point(6, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoSebo.Properties.Resources.codigo_barras;
            this.pictureBox1.Location = new System.Drawing.Point(6, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // imgCodBarras
            // 
            this.imgCodBarras.Image = global::ProjetoSebo.Properties.Resources.codigo_barras;
            this.imgCodBarras.Location = new System.Drawing.Point(6, 77);
            this.imgCodBarras.Name = "imgCodBarras";
            this.imgCodBarras.Size = new System.Drawing.Size(40, 40);
            this.imgCodBarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCodBarras.TabIndex = 31;
            this.imgCodBarras.TabStop = false;
            // 
            // lblIdentificacaoTela
            // 
            this.lblIdentificacaoTela.AutoSize = true;
            this.lblIdentificacaoTela.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentificacaoTela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblIdentificacaoTela.Location = new System.Drawing.Point(3, 3);
            this.lblIdentificacaoTela.Name = "lblIdentificacaoTela";
            this.lblIdentificacaoTela.Size = new System.Drawing.Size(112, 31);
            this.lblIdentificacaoTela.TabIndex = 21;
            this.lblIdentificacaoTela.Text = "Usuários";
            // 
            // pnlLinhaConfirmarSenha
            // 
            this.pnlLinhaConfirmarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaConfirmarSenha.Location = new System.Drawing.Point(6, 250);
            this.pnlLinhaConfirmarSenha.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.pnlLinhaConfirmarSenha.Name = "pnlLinhaConfirmarSenha";
            this.pnlLinhaConfirmarSenha.Size = new System.Drawing.Size(250, 2);
            this.pnlLinhaConfirmarSenha.TabIndex = 20;
            // 
            // pnlLinhaSenha
            // 
            this.pnlLinhaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaSenha.Location = new System.Drawing.Point(6, 182);
            this.pnlLinhaSenha.Name = "pnlLinhaSenha";
            this.pnlLinhaSenha.Size = new System.Drawing.Size(250, 2);
            this.pnlLinhaSenha.TabIndex = 19;
            // 
            // pnlLinhaLogin
            // 
            this.pnlLinhaLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLinhaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.pnlLinhaLogin.Location = new System.Drawing.Point(6, 118);
            this.pnlLinhaLogin.Name = "pnlLinhaLogin";
            this.pnlLinhaLogin.Size = new System.Drawing.Size(500, 2);
            this.pnlLinhaLogin.TabIndex = 18;
            // 
            // imgFoto
            // 
            this.imgFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgFoto.Image = global::ProjetoSebo.Properties.Resources.foto_usuario;
            this.imgFoto.Location = new System.Drawing.Point(574, 89);
            this.imgFoto.Name = "imgFoto";
            this.imgFoto.Size = new System.Drawing.Size(120, 160);
            this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFoto.TabIndex = 17;
            this.imgFoto.TabStop = false;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BackColor = System.Drawing.SystemColors.Control;
            this.txtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.txtConfirmarSenha.Location = new System.Drawing.Point(55, 223);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(200, 22);
            this.txtConfirmarSenha.TabIndex = 15;
            this.txtConfirmarSenha.Text = "Confirmar";
            this.txtConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Control;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.txtSenha.Location = new System.Drawing.Point(56, 155);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(200, 22);
            this.txtSenha.TabIndex = 13;
            this.txtSenha.Text = "Senha";
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.BackColor = System.Drawing.SystemColors.Control;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.txtLogin.Location = new System.Drawing.Point(55, 91);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(450, 22);
            this.txtLogin.TabIndex = 11;
            this.txtLogin.Text = "Login";
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
            this.btnGravar.Location = new System.Drawing.Point(496, 436);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(200, 50);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // TelaUsuariosCadastro
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
            this.Name = "TelaUsuariosCadastro";
            this.Text = "TelaUsuariosCadastro";
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.pnlCentral.ResumeLayout(false);
            this.pnlCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCodBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Panel pnlInferior;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.PictureBox imgFoto;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.Panel pnlLinhaLogin;
        private System.Windows.Forms.Panel pnlLinhaConfirmarSenha;
        private System.Windows.Forms.Panel pnlLinhaSenha;
        private System.Windows.Forms.Label lblIdentificacaoTela;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgCodBarras;
    }
}