using ProjetoSebo.views;

namespace ProjetoSebo.telas
{
    partial class TelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.PictureBox();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblNomeSistema = new System.Windows.Forms.Label();
            this.pnlTitulo = new TituloPanel(this);
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUser)).BeginInit();
            this.pnlLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.btnEntrar);
            this.pnlMain.Controls.Add(this.txtSenha);
            this.pnlMain.Controls.Add(this.txtLogin);
            this.pnlMain.Controls.Add(this.lblPassword);
            this.pnlMain.Controls.Add(this.lblUser);
            this.pnlMain.Location = new System.Drawing.Point(0, 150);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(350, 350);
            this.pnlMain.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.panel2.Location = new System.Drawing.Point(78, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 1);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.panel1.Location = new System.Drawing.Point(78, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 1);
            this.panel1.TabIndex = 9;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.White;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnEntrar.Image = global::ProjetoSebo.Properties.Resources.enviar;
            this.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrar.Location = new System.Drawing.Point(78, 202);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(200, 50);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(78, 106);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(208, 22);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(78, 56);
            this.txtLogin.Name = "txtUser";
            this.txtLogin.Size = new System.Drawing.Size(208, 22);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            this.lblPassword.Image = ((System.Drawing.Image)(resources.GetObject("lblPassword.Image")));
            this.lblPassword.Location = new System.Drawing.Point(42, 105);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(30, 30);
            this.lblPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lblPassword.TabIndex = 2;
            this.lblPassword.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.Image = global::ProjetoSebo.Properties.Resources.usuario_login;
            this.lblUser.Location = new System.Drawing.Point(42, 55);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(30, 30);
            this.lblUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lblUser.TabIndex = 1;
            this.lblUser.TabStop = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogo.BackColor = System.Drawing.Color.White;
            this.pnlLogo.Controls.Add(this.lblNomeSistema);
            this.pnlLogo.Location = new System.Drawing.Point(0, 30);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(350, 120);
            this.pnlLogo.TabIndex = 2;
            // 
            // lblNomeSistema
            // 
            this.lblNomeSistema.AutoSize = true;
            this.lblNomeSistema.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(109)))), ((int)(((byte)(206)))));
            this.lblNomeSistema.Location = new System.Drawing.Point(104, 46);
            this.lblNomeSistema.Name = "lblNomeSistema";
            this.lblNomeSistema.Size = new System.Drawing.Size(148, 28);
            this.lblNomeSistema.TabIndex = 0;
            this.lblNomeSistema.Text = "Sistema Sebo";
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitulo.BackColor = System.Drawing.Color.White;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(350, 30);
            this.pnlTitulo.TabIndex = 0;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUser)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.PictureBox lblPassword;
        private System.Windows.Forms.PictureBox lblUser;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private TituloPanel pnlTitulo;
        private System.Windows.Forms.Label lblNomeSistema;
    }
}