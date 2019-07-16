using ProjetoSebo.bean;
using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.validator;
using System;
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
                    Context.LocaisProduto.Add(new LocalProdutoModel(local));
                    Context.SaveChanges();
                }
            }

            return new ResultadoSucesso();
        }

        public override ResultadoOperacao OnConsistirDados(BaseParaBean dados)
        {
            //Local local = dados as Local;

            return new ResultadoSucesso();
        }

        public List<LocalProduto> BuscarTodos()
        {
            List<LocalProduto> lista = new List<LocalProduto>();

            foreach(LocalProdutoModel model in Context.LocaisProduto)
            {
                lista.Add(model.ConverterParaBean());
            }

            return lista;
        }

        public LocalProduto BuscarPelaDescricao(string descricao)
        {
            IQueryable<LocalProdutoModel> retorno = Context.LocaisProduto.Where(t => t.Descricao == descricao);

            if (retorno.Count() > 0)
                return retorno.First().ConverterParaBean();

            return new LocalProduto();
        }
    }
}
