using ProjetoSebo.dao;
using ProjetoSebo.error;
using ProjetoSebo.model;
using ProjetoSebo.views;
using ProjetoSebo.views.components;
using System.Windows.Forms;

namespace ProjetoSebo.controller
{
    public abstract class BaseParaController
    {
        public SeboContext Context { get; set; }
        public IBaseParaTela Tela { get; set; }

        public enum TipoQuestionamento
        {
            Sempre = 0,
            SomenteTelaCadastro,
            ExcetoTelaCadastro,
        }

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

        public bool ExibirQuestionamento(string mensagem, TipoQuestionamento tipoQuestionamento)
        {
            if(VerificaDeveQuestionar(tipoQuestionamento) && mensagem.Length > 0)
            {
                return MessageBox.Show(mensagem, GlobalResource.NOME_SOFTWARE, MessageBoxButtons.YesNo) == DialogResult.Yes;
            }

            return true;
        }

        private bool VerificaDeveQuestionar(TipoQuestionamento tipoQuestionamento)
        {
            if (tipoQuestionamento == TipoQuestionamento.ExcetoTelaCadastro)
                return this.Tela == null;

            if (tipoQuestionamento == TipoQuestionamento.SomenteTelaCadastro)
                return this.Tela != null;

            return true;
        }
    }
}
