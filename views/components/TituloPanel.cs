using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSebo.views
{
    partial class TituloPanel
    { 
        private Form _tela;

        public enum Botoes
        {
            Fechar = 1,
            Minimizar = 2,
            Maximizar = 4,

            Todos = Fechar | Minimizar | Maximizar
        }

        public TituloPanel(Form tela)
        {
            _tela = tela;

            InitializeComponent();
        }

        public void ExibirBotoes(Botoes configuracao)
        {
            Point posBotao = new Point(_tela.Size.Width - btnFechar.Width, 0);

            btnFechar.Visible = (configuracao & Botoes.Fechar) != 0;
            if (btnFechar.Visible)
                posBotao.X -= btnFechar.Width;

            if ( (configuracao & Botoes.Maximizar) != 0 )
            {
                btnRestaurar.Visible = _tela.WindowState == FormWindowState.Maximized;
                btnMaximizar.Visible = _tela.WindowState != FormWindowState.Maximized;

                btnRestaurar.Location = posBotao;
                btnMaximizar.Location = posBotao;

                posBotao.X -= btnMaximizar.Width;
            }
            else
            {
                btnRestaurar.Visible = false;
                btnMaximizar.Visible = false;
            }

            btnMinimizar.Visible = (configuracao & Botoes.Minimizar) != 0;
            if (btnMinimizar.Visible)
                btnMinimizar.Location = posBotao;
        }

        //Eventos
        private void btnFechar_Click(object sender, EventArgs e)
        {
            _tela.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            _tela.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            _tela.WindowState = FormWindowState.Maximized;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            _tela.WindowState = FormWindowState.Normal;

            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

    }
}
