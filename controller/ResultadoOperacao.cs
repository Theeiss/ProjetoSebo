using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSebo.controller
{
    public abstract class ResultadoOperacao
    {
        public ResultadoOperacao(string mensagem)
        {
            this.Mensagem = mensagem;
        }

        public string Mensagem { get; set; }

        public bool VerificarSucessoOperacao()
        {
            return this.GetType() == typeof(ResultadoSucesso);
        }

        public bool VerificarFalhaOperacao()
        {
            return this.GetType() == typeof(ResultadoAviso) || this.GetType() == typeof(ResultadoErro);
        }

        public void Exibir()
        {
            if (this.Mensagem.Length == 0)
                return;

            MessageBox.Show(this.Mensagem, "Sistema Sebo", MessageBoxButtons.OK, GetMessageBoxIcon());
        }

        public abstract MessageBoxIcon GetMessageBoxIcon();
    }

    public class ResultadoAviso : ResultadoOperacao
    {
        public ResultadoAviso(string mensagem) : base(mensagem)
        {
        }

        public override MessageBoxIcon GetMessageBoxIcon()
        {
            return MessageBoxIcon.Warning;
        }
    }

    public class ResultadoErro : ResultadoOperacao
    {
        public ResultadoErro(string mensagem) : base(mensagem)
        {
        }

        public override MessageBoxIcon GetMessageBoxIcon()
        {
            return MessageBoxIcon.Error;
        }
    }

    public class ResultadoSucesso : ResultadoOperacao
    {
        public ResultadoSucesso() : base("")
        {
        }

        public ResultadoSucesso(string mensagem) : base(mensagem)
        {
        }

        public override MessageBoxIcon GetMessageBoxIcon()
        {
            return MessageBoxIcon.Information;
        }
    }
}
