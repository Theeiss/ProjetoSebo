using ProjetoSebo.dao;
using System;
using System.Windows.Forms;

namespace ProjetoSebo.views
{
    public partial class TelaUsuarios : Form
    {
        public Form TelaSelecionada { get; private set; }

        private readonly SeboContext _context;
        public TelaUsuarios(SeboContext context)
        {
            this._context = context;

            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            TelaSelecionada = new TelaUsuariosCadastro(this._context);
            MessageBox.Show("Abrir tela de usuários - cadastro.");
        }
    }
}
