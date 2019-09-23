using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.views.components;
using ProjetoSebo.views.telas_finais;
using System.Linq;

namespace ProjetoSebo.views
{
    public partial class TelaConsultaUsuarios : BaseParaTela<UsuarioController>
    {
        public TelaConsultaUsuarios(SeboContext context) :
            base(context, new UsuarioController())
        {
            InitializeComponent();
            //base.AtalhoTelaInclusao = new TelaUsuarios(context);
            base.AtalhoTelaConsulta = this;
            base.AtalhoTelaRelatorio = new TelaTipoProduto(context); //Tela apenas para teste
        }

        private void TelaConsultaUsuarios_Load(object sender, System.EventArgs e)
        {
            CarregarTabela();
        }

        private void CarregarTabela()
        {
            var data = from usuario in Controller.Buscar()
                       orderby usuario.Login
                       select new
                       {
                           usuario.Login,
                       };

            this.tblUsuarios.DataSource = data.ToList();
        }
    }
}
