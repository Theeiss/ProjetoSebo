using ProjetoSebo.telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSebo.views
{
    partial class TituloPanel : Panel
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));

            this.btnFechar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.imgLogoTitulo = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.imgLogoTitulo)).BeginInit();
            this.SuspendLayout();

            // 
            // imgLogoTitulo
            // 
            this.imgLogoTitulo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
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
            this.lblTitulo.Text = "Login";

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
            this.Controls.Add(lblTitulo);
            this.Controls.Add(imgLogoTitulo);
            

            ((System.ComponentModel.ISupportInitialize)(this.imgLogoTitulo)).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox imgLogoTitulo;
    }
}
