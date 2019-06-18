using ProjetoSebo.dao;
using System;
using System.Windows.Forms;

namespace ProjetoSebo.views
{
    public partial class TelaUsuariosCadastro : Form
    {
        private readonly SeboContext _context;

        public TelaUsuariosCadastro(SeboContext context)
        {
            this._context = context;

            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
