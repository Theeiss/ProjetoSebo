using ProjetoSebo.model;
using ProjetoSebo.error;
using ProjetoSebo.validator;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSebo.controller
{
    public class LocalProdutoController : BaseParaController
    {
        public const int CAMPO_DESCRICAO = 1;

        public LocalValidator Validator { get; set; }

        public LocalProdutoController()
        {
            Validator = new LocalValidator();
        }

        public ResultadoOperacao Gravar(LocalProduto local)
        {
            ResultadoOperacao resultado = ConsistirDados(local);
            if (resultado.VerificarFalhaOperacao())
                return resultado;

            if (Context.LocaisProduto.Where(t => t.Descricao == local.Descricao).Count() == 0)
            {
                if (ExibirQuestionamento(string.Format("O local {0} não existe no sistema. Deseja adicioná-lo?", local.Descricao), TipoQuestionamento.ExcetoTelaCadastro))
                {
                    Context.LocaisProduto.Add(local);
                    Context.SaveChanges();
                }
            }

            return new ResultadoSucesso();
        }

        public override ResultadoOperacao OnConsistirDados(BaseParaModel dados)
        {
            return new ResultadoSucesso();
        }

        public List<LocalProduto> Buscar()
        {
            return Context.LocaisProduto.ToList();
        }

        public List<LocalProduto> Buscar(LocalProduto filtro)
        {
            IQueryable<LocalProduto> query = from localProduto in Context.LocaisProduto
                                             where (filtro.Id == 0 || localProduto.Id == filtro.Id) &&
                                                   (string.IsNullOrEmpty(filtro.Descricao) || localProduto.Descricao == filtro.Descricao)
                                             select localProduto;

            return query.ToList();
        }

        public LocalProduto BuscarPelaDescricao(string descricao)
        {
            LocalProduto filtro = new LocalProduto()
            {
                Descricao = descricao
            };
            List<LocalProduto> resultado = Buscar(filtro);

            if (resultado.Count == 0)
                return null;

            return resultado.First();
        }
    }
}
