using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.validator;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSebo.controller
{
    public class TipoProdutoController : BaseParaController
    {
        public const int CAMPO_DESCRICAO = 1;

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

            if (retorno == null)
            {
                if( ExibirQuestionamento(string.Format("O tipo de produto {0} não existe no sistema. Deseja adicioná-lo?", tipoProduto.Descricao), TipoQuestionamento.ExcetoTelaCadastro) )
                {
                    Context.TiposProduto.Add(tipoProduto);
                    Context.SaveChanges();
                }
                else
                {
                    return new ResultadoSilencioso();
                }
            }

            return new ResultadoSucesso();
        }

        public override ResultadoOperacao OnConsistirDados(BaseParaModel dados)
        {
            TipoProduto tipoProduto = dados as TipoProduto;

            ResultadoOperacao resultado = this.Validator.ConsistirDescricao(tipoProduto.Descricao);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Campo = CAMPO_DESCRICAO;
                return resultado;
            }

            return new ResultadoSucesso();
        }

        public List<TipoProduto> Buscar()
        {
            return Context.TiposProduto.ToList();
        }

        public List<TipoProduto> Buscar(TipoProduto filtro)
        {
            IQueryable<TipoProduto> query = from tipoProduto in Context.TiposProduto
                                            where (filtro.Id == 0 || tipoProduto.Id == filtro.Id) &&
                                                  (string.IsNullOrEmpty(filtro.Descricao) || tipoProduto.Descricao == filtro.Descricao)
                                            select tipoProduto;

            return query.ToList();
        }

        public TipoProduto BuscarPelaDescricao(string descricao)
        {
            TipoProduto filtro = new TipoProduto()
            {
                Descricao = descricao
            };
            List<TipoProduto> resultado = Buscar(filtro);

            if (resultado.Count == 0)
                return null;

            return resultado.First();
        }
    }
}
