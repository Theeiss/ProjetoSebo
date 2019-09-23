using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.views.components;
using System;
using System.Data;
using System.Linq;

namespace ProjetoSebo.views.telas_finais
{
    public partial class TelaConsultaCliente : BaseParaTela<ClienteController>
    {
        public TelaConsultaCliente(SeboContext context) :
            base(context, new ClienteController())
        {
            base.AtalhoTelaInclusao = new TelaClientes(context);
            base.AtalhoTelaConsulta = this;
            base.AtalhoTelaRelatorio = new TelaTipoProduto(context); //Somente para teste.

            InitializeComponent();
        }

        private void TelaConsultaCliente_Load(object sender, EventArgs e)
        {
            CarregarTabela();
        }

        private void CarregarTabela()
        {
            var data = from cliente in Controller.Buscar()
                       orderby cliente.Nome
                       select new
                       {
                           cliente.Nome,
                           cliente.Cpf,
                           cliente.DataNascimento,
                           cliente.Sexo,
                           cliente.Telefone,
                           cliente.Email,
                           cliente.Observacao
                       };

            this.tblClientes.DataSource = data.ToList();
        }
    }
}
