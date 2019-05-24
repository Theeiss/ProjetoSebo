using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjetoSebo.views
{
    partial class TituloPanel : Panel
    {
        private System.ComponentModel.IContainer components = null;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(_tela.Handle, 0x112, 0xf012, 0);

            base.OnMouseDown(e);
        }

        private void InitializeComponent()
        {
            this.btnFechar = new Button();
            this.btnMinimizar = new Button();
            this.btnMaximizar = new Button();
            this.btnRestaurar = new Button();
            this.lblTitulo = new Label();
            this.imgLogoTitulo = new PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.imgLogoTitulo)).BeginInit();
            this.SuspendLayout();

            // 
            // imgLogoTitulo
            // 
            this.imgLogoTitulo.Image = GlobalResource.logo;
            this.imgLogoTitulo.Location = new System.Drawing.Point(1, 0);
            this.imgLogoTitulo.Name = "pictureBox2";
            this.imgLogoTitulo.Size = new System.Drawing.Size(30, 30);
            this.imgLogoTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoTitulo.TabIndex = 3;
            this.imgLogoTitulo.TabStop = false;

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(45, 3);
            this.lblTitulo.Name = "label1";
            this.lblTitulo.Size = new System.Drawing.Size(52, 21);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = this._tela.Text;

            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(320, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 30);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "X";
            this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);

            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(260, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 5;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);

            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Location = new System.Drawing.Point(290, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizar.TabIndex = 6;
            this.btnMaximizar.Text = "[]";
            this.btnMaximizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);

            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.ForeColor = System.Drawing.Color.White;
            this.btnRestaurar.Location = new System.Drawing.Point(290, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(30, 30);
            this.btnRestaurar.TabIndex = 7;
            this.btnRestaurar.Text = "[]|";
            this.btnRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);

            // 
            // pnlTitulo
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.imgLogoTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnFechar);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "pnlTitulo";
            this.Size = new System.Drawing.Size(350, 30);
            this.TabIndex = 0;

            this.Controls.Add(btnFechar);
            this.Controls.Add(btnMinimizar);
            this.Controls.Add(btnMaximizar);
            this.Controls.Add(btnRestaurar);
            this.Controls.Add(lblTitulo);
            this.Controls.Add(imgLogoTitulo);
            

            ((System.ComponentModel.ISupportInitialize)(this.imgLogoTitulo)).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox imgLogoTitulo;
    }
}
