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

        const int TAM_MENU_MINIMIZADO = 70;
        const int TAM_MENU_MAXIMIZADO = 250;

        public TelaPrincipal(SeboContext context)
        {
            this._context = context;

            InitializeComponent();

            this.pnlMenuLateral.Width = TAM_MENU_MINIMIZADO;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if(this.pnlMenuLateral.Width == TAM_MENU_MAXIMIZADO)
            {
                this.pnlMenuLateral.Width = TAM_MENU_MINIMIZADO;
            }
            else
            {
                this.pnlMenuLateral.Width = TAM_MENU_MAXIMIZADO;
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.btnMaximizar.Visible = false;
            this.btnRestaurar.Visible = true;
        }
        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            TelaUsuarios telaUsuarios = new TelaUsuarios(_context);
            AbrirTelaInterna(telaUsuarios);
        }

        private void AbrirTelaInterna(object telaInterna)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
                this.pnlPrincipal.Controls.RemoveAt(0);

            Form nova = telaInterna as Form;
            nova.TopLevel = false;
            nova.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(nova);
            this.pnlPrincipal.Tag = nova;
            nova.Show();
        }
    }
}
