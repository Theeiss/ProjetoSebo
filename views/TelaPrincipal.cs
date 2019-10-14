using ProjetoSebo.dao;
using ProjetoSebo.views.components;
using ProjetoSebo.views.telas_finais;
using ProjetoSebo.views.telas_finais.consulta;
using ProjetoSebo.views.telas_finais.inclusao;
using ProjetoSebo.views.telas_finais.outras;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjetoSebo.views
{
    public partial class TelaPrincipal : Form
    {
        private readonly SeboContext _context;
        private IBaseParaTela TelaAberta { get; set; }

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

        private void AbrirTelaInterna(object telaInterna, bool abrindoAtalho = false)
        {
            if (this.pnlPrincipal.Controls.Count > 0)
                this.pnlPrincipal.Controls.RemoveAt(0);

            Form nova = telaInterna as Form;
            nova.TopLevel = false;
            nova.Dock = DockStyle.Fill;
            this.pnlPrincipal.Controls.Add(nova);
            this.pnlPrincipal.Tag = nova;

            if (!abrindoAtalho)
            {
                TelaAberta = telaInterna as IBaseParaTela;

                btnInclusao.Visible = TelaAberta != null && TelaAberta.GetAtalhoTelaInclusao() != null;
                btnConsulta.Visible = TelaAberta != null && TelaAberta.GetAtalhoTelaConsulta() != null;
                btnRelatorio.Visible = TelaAberta != null && TelaAberta.GetAtalhoTelaRelatorio() != null;
            }

            nova.Show();
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            //TelaProdutos telaProdutos = new TelaProdutos(_context);
            //AbrirTelaInterna(telaProdutos);

            TelaConsultaProdutos telaConsultaProdutos = new TelaConsultaProdutos(_context);
            AbrirTelaInterna(telaConsultaProdutos);
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            TelaVendas2 telaVendas = new TelaVendas2();
            AbrirTelaInterna(telaVendas);
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            TelaUsuariosCadastro telaUsuariosCadastro = new TelaUsuariosCadastro(_context);
            AbrirTelaInterna(telaUsuariosCadastro);
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            TelaClientes telaClientes = new TelaClientes(_context);
            AbrirTelaInterna(telaClientes);
        }

        private void BtnPreferencias_Click(object sender, EventArgs e)
        {
            //TelaPreferencias telaPreferencias = new TelaPreferencias();
            //AbrirTelaInterna(telaPreferencias);

            TelaTeste telaTeste = new TelaTeste(_context);
            AbrirTelaInterna(telaTeste);
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            TelaCompras telaCompras = new TelaCompras(_context);
            AbrirTelaInterna(telaCompras);
        }

        private void BtnDoacoes_Click(object sender, EventArgs e)
        {
            TelaDoacoes telaDoacoes = new TelaDoacoes(_context);
            AbrirTelaInterna(telaDoacoes);
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            if (this.TelaAberta == null)
                return;

            if (this.TelaAberta.GetAtalhoTelaConsulta() != null)
            {
                AbrirTelaInterna(this.TelaAberta.GetAtalhoTelaConsulta(), true);
            }
        }

        private void BtnInclusao_Click(object sender, EventArgs e)
        {
            if (this.TelaAberta == null)
                return;

            if (this.TelaAberta.GetAtalhoTelaInclusao() != null)
            {
                AbrirTelaInterna(this.TelaAberta.GetAtalhoTelaInclusao(), true);
            }
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            if (this.TelaAberta == null)
                return;

            if (this.TelaAberta.GetAtalhoTelaRelatorio() != null)
            {
                AbrirTelaInterna(this.TelaAberta.GetAtalhoTelaRelatorio(), true);
            }
        }
    }
}
