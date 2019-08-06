using ProjetoSebo.model;
using ProjetoSebo.dao;
using System;
using System.Windows.Forms;
using ProjetoSebo.controller;
using System.Collections.Generic;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaTeste : Form
    {
        UsuarioController ControllerUsuario;

        public TelaTeste(SeboContext context)
        {
            InitializeComponent();
            this.txtProduto.SetContext(context);

            ControllerUsuario = new UsuarioController();
            ControllerUsuario.Context = context;
        }

        private void BtnTestar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = this.txtData.Data.ToString();
        }

        private void BtnTestar2_Click(object sender, EventArgs e)
        {
            this.lblResultado2.Text = this.txtValor.Valor + "";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            this.txtValor.Clear();
        }

        private void BtnBuscarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = this.txtProduto.Produto;

            this.lblResultadoProduto.Text = this.txtProduto.Produto == null ? "Nulo" : this.txtProduto.Produto.Descricao;
        }

        private void BtnFoto_Click(object sender, EventArgs e)
        {
            Usuario filtro = new Usuario();
            filtro.Login = this.txtUsuario.Text;

            List<Usuario> usuarios = ControllerUsuario.Buscar(filtro);

            if (usuarios.Count > 0)
            {
                this.imgFotoUsuario.Image = ControllerUsuario.LerFotoUsuario(usuarios[0]);
            }
        }
    }
}
