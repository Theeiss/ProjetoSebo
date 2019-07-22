using ProjetoSebo.bean;
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

            if (Context.TiposProduto.Where(t => t.Descricao == tipoProduto.Descricao).Count() == 0)
            {
                if( ExibirQuestionamento(string.Format("O tipo de produto {0} não existe no sistema. Deseja adicioná-lo?", tipoProduto.Descricao), TipoQuestionamento.ExcetoTelaCadastro) )
                {
                    Context.TiposProduto.Add(new TipoProdutoModel(tipoProduto));
                    Context.SaveChanges();
                }                
            }

            return new ResultadoSucesso();
        }

        public override ResultadoOperacao OnConsistirDados(BaseParaBean dados)
        {
            //TipoProduto tipoProduto = dados as TipoProduto;

            return new ResultadoSucesso();
        }

        public List<TipoProduto> BuscarTodos()
        {
            List<TipoProduto> lista = new List<TipoProduto>();

            foreach (TipoProdutoModel model in Context.TiposProduto)
            {
                lista.Add(model.ConverterParaBean());
            }

            return lista;
        }

        public TipoProduto BuscarPelaDescricao(string descricao)
        {
            IQueryable<TipoProdutoModel> retorno = Context.TiposProduto.Where(t => t.Descricao == descricao);

            if(retorno.Count() > 0)
                return retorno.First().ConverterParaBean();
            
            return new TipoProduto();
        }
    }
}
