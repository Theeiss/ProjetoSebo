using ProjetoSebo.dao;
using ProjetoSebo.views.telas_finais;
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

        private void Maximizar()
        {
            this.WindowState = FormWindowState.Maximized;
            this.btnMaximizar.Visible = false;
            this.btnRestaurar.Visible = true;
        }

        private void Minimizar()
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Restaurar()
        {
            if (this.pnlMenuLateral.Width == TAM_MENU_MAXIMIZADO)
                this.pnlMenuLateral.Width = TAM_MENU_MINIMIZADO;

            this.WindowState = FormWindowState.Normal;
            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (this.pnlMenuLateral.Width == TAM_MENU_MAXIMIZADO)
            {
                this.pnlMenuLateral.Width = TAM_MENU_MINIMIZADO;
            }
            else
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.Maximizar();
                }

                this.pnlMenuLateral.Width = TAM_MENU_MAXIMIZADO;
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.Maximizar();
        }
        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.Restaurar();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.Minimizar();
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

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            TelaProdutos telaProdutos = new TelaProdutos(_context);
            AbrirTelaInterna(telaProdutos);
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            TelaVendas telaVendas = new TelaVendas(_context);
            AbrirTelaInterna(telaVendas);
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            TelaUsuariosCadastro telaUsuariosCadastro = new TelaUsuariosCadastro(_context);
            AbrirTelaInterna(telaUsuariosCadastro);
        }
    }
}
