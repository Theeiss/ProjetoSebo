using ProjetoSebo.dao;
using ProjetoSebo.telas;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjetoSebo.views
{
    public partial class TelaPrincipal : Form
    {
        private readonly SeboContext _context;

        public TelaPrincipal(SeboContext context)
        {
            this._context = context;

            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if(this.pnlMenuLateral.Width == 250)
            {
                this.pnlMenuLateral.Width = 70;
            }
            else
            {
                this.pnlMenuLateral.Width = 250;
            }
        }

        private void BtnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.btnMaximizar.Visible = false;
            this.btnRestaurar.Visible = true;
        }
        private void BtnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
        }

        private void BtnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            new TelaLogin(this._context).ShowDialog();
        }

        private void PnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
