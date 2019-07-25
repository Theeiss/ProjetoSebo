using ProjetoSebo.model;
using ProjetoSebo.error;
using ProjetoSebo.validator;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSebo.controller
{
    public class LocalProdutoController : BaseParaController
    {
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
            //Local local = dados as Local;

            return new ResultadoSucesso();
        }

        public List<LocalProduto> BuscarTodos()
        {
            List<LocalProduto> lista = new List<LocalProduto>();

            foreach(LocalProduto model in Context.LocaisProduto)
            {
                lista.Add(model);
            }

            return lista;
        }

        public LocalProduto BuscarPelaDescricao(string descricao)
        {
            IQueryable<LocalProduto> resultado = Context.LocaisProduto.Where(t => t.Descricao == descricao);

            if (resultado.Count() > 0)
                return resultado.First();

            return new LocalProduto();
        }
    }
}
