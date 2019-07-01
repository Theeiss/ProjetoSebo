using ProjetoSebo.model;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSebo.controller
{
    public class LocalController : BaseParaController
    {
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

        public ResultadoOperacao ConsistirDados(Local local)
        {
            return new ResultadoSucesso();
        }

        public List<Local> BuscarTodos()
        {
            return new List<Local>(Context.Locais);
        }
    }
}
