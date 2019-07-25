using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.validator;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSebo.controller
{
    public class TipoProdutoController : BaseParaController
    {
        public TipoProdutoValidator Validator { get; set; }

        public TipoProdutoController()
        {
            this.Validator = new TipoProdutoValidator();
        }

        public ResultadoOperacao Gravar(TipoProduto tipoProduto)
        {
            ResultadoOperacao resultado = ConsistirDados(tipoProduto);
            if (resultado.VerificarFalhaOperacao())
                return resultado;

            TipoProduto retorno = BuscarPelaDescricao(tipoProduto.Descricao);

            if (retorno.Id == 0)
            {
                if( ExibirQuestionamento(string.Format("O tipo de produto {0} não existe no sistema. Deseja adicioná-lo?", tipoProduto.Descricao), TipoQuestionamento.ExcetoTelaCadastro) )
                {
                    Context.TiposProduto.Add(tipoProduto);
                    Context.SaveChanges();
                }                
            }
            else
            {
                tipoProduto = retorno;
            }

            return new ResultadoSucesso();
        }

        public override ResultadoOperacao OnConsistirDados(BaseParaModel dados)
        {
            //TipoProduto tipoProduto = dados as TipoProduto;

            return new ResultadoSucesso();
        }

        public List<TipoProduto> BuscarTodos()
        {
            return Context.TiposProduto;
        }

        public TipoProduto BuscarPelaDescricao(string descricao)
        {
            return Context.TiposProduto.Where(t => t.Descricao == descricao).First();
        }
    }
}
