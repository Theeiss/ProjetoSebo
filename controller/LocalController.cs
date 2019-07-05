using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.validator;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSebo.controller
{
    public class LocalController : BaseParaController
    {
        public LocalValidator Validator { get; set; }

        public LocalController()
        {
            Validator = new LocalValidator();
        }

        public ResultadoOperacao Gravar(Local local)
        {
            ResultadoOperacao resultado = ConsistirDados(local);
            if (resultado.VerificarFalhaOperacao())
                return resultado;

            if (Context.Locais.Where(t => t.Descricao == local.Descricao).Count() == 0)
            {
                Context.Locais.Add(local);
                Context.SaveChanges();
            }

            return new ResultadoSucesso();
        }

        public override ResultadoOperacao OnConsistirDados(BaseParaModel dados)
        {
            //Local local = dados as Local;

            return new ResultadoSucesso();
        }

        public List<Local> BuscarTodos()
        {
            return new List<Local>(Context.Locais);
        }
    }
}
