using ProjetoSebo.controller;
using ProjetoSebo.dao;
using System;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public class BaseParaTela<TController> : Form
        where TController : BaseParaController
    {
        public TController Controller { get; set; }

        public BaseParaTela()
        {
        }
        public BaseParaTela(SeboContext context, TController controller)
        {
            this.Controller = controller;
            this.Controller.Context = context;

            InitializeComponent();
        }

        protected virtual void InitializeComponent()
        {
        }
    }
}
