﻿using ProjetoSebo.views;
using System.Windows.Forms;

namespace ProjetoSebo.error
{
    public abstract class ResultadoOperacao
    {
        public ResultadoOperacao(string mensagem, int campo)
        {
            this.Mensagem = mensagem;
            this.Campo = campo;
        }

        public ResultadoOperacao(string mensagem)
        {
            this.Mensagem = mensagem;
        }

        public string Mensagem { get; set; }
        public int Campo { get; set; }

        public bool VerificarSucessoOperacao()
        {
            return this.GetType() == typeof(ResultadoSucesso);
        }

        public bool VerificarFalhaOperacao()
        {
            return this.GetType() == typeof(ResultadoAviso) || this.GetType() == typeof(ResultadoErro) || this.GetType() == typeof(ResultadoSilencioso);
        }

        public void Exibir()
        {
            if (this.Mensagem.Length == 0)
                return;

            if (this.GetType() == typeof(ResultadoSilencioso))
                return;

            MessageBox.Show(this.Mensagem, GlobalResource.NOME_SOFTWARE, MessageBoxButtons.OK, GetMessageBoxIcon());
        }

        public abstract MessageBoxIcon GetMessageBoxIcon();
    }

    public class ResultadoAviso : ResultadoOperacao
    {
        public ResultadoAviso(string mensagem) : base(mensagem)
        {
        }

        public ResultadoAviso(string mensagem, int campo) : base(mensagem, campo)
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

        public ResultadoErro(string mensagem, int campo) : base(mensagem, campo)
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

        public ResultadoSucesso(string mensagem, int campo) : base(mensagem, campo)
        {
        }

        public override MessageBoxIcon GetMessageBoxIcon()
        {
            return MessageBoxIcon.Information;
        }
    }

    public class ResultadoSilencioso : ResultadoOperacao
    {
        public ResultadoSilencioso() : base("")
        {
        }

        public override MessageBoxIcon GetMessageBoxIcon()
        {
            return MessageBoxIcon.None;
        }
    }
}
