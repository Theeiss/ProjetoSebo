using ProjetoSebo.bean;
using ProjetoSebo.dao;
using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.views.components;

namespace ProjetoSebo.controller
{
    public abstract class BaseParaController
    {
        public SeboContext Context { get; set; }
        public IBaseParaTela Tela { get; set; }

        protected ResultadoOperacao ConsistirDados(BaseParaBean dados)
        {
            ResultadoOperacao retorno = OnConsistirDados(dados);

            if (retorno.VerificarFalhaOperacao())
            {
                Tela.TratarConsistencia(retorno);
            }

            return retorno;
        }

        public abstract ResultadoOperacao OnConsistirDados(BaseParaBean dados);
    }
}
