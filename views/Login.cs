using ProjetoSebo.dao;
using ProjetoSebo.model;
using ProjetoSebo.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSebo.telas
{
    public partial class Login : Form
    {
        private readonly SeboContext _context;
        public Login(SeboContext context)
        {
            _context = context;

            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnlTitulo.ExibirBotoes(TituloPanel.Botoes.Fechar);
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtUser.Text;
            string senha = txtSenha.Text;

            IQueryable<Usuario> resultado = _context.Usuarios.Where(usuario => usuario.Login == login)
                 .Where(usuario => usuario.Senha == senha)
                 .Select(usuario => usuario);

            if(resultado.GetEnumerator().MoveNext())
            {
                MessageBox.Show("Achou filha da puta");
            }
            else
            {
                MessageBox.Show("Que pena! Você perdeu.");
            }

            //foreach (Usuario usuario in _context.Usuarios)
            //{
            //    if(usuario.Login == login && usuario.Senha == senha)
            //    {
            //        MessageBox.Show("Achou filha da puta");
            //        return;
            //    }
            //}

            //MessageBox.Show("Que pena! Você perdeu.");
        }
    }
}
