using ProjetoSebo.bean;
using ProjetoSebo.controller;
using ProjetoSebo.error;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public class ComboLocais : ComboBox
    {
        private LocalController Controller { get; set; }
        private List<Local> Locais { get; set; }

        public ComboLocais()
        {
            Controller = new LocalController();
        }

        private void Carregar()
        {
            this.Locais = this.Controller.BuscarTodos();

            this.Locais.Sort();

            this.Items.Clear();
            this.Locais.ForEach(tipo => this.Items.Add(tipo.Descricao));
        }
        protected override void OnDropDown(EventArgs e)
        {
            Carregar();

            base.OnDropDown(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (Text.Length == 0)
                return;

            Local local = new Local()
            {
                Descricao = this.Text
            };

            ResultadoOperacao resultado = Controller.Gravar(local);
            if (resultado.VerificarFalhaOperacao())
            {
                resultado.Exibir();
                return;
            }

            base.OnLostFocus(e);
        }
    }
}
