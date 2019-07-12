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
                Context.TiposProduto.Add(new TipoProdutoModel(tipoProduto));
                Context.SaveChanges();
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
    }
}
