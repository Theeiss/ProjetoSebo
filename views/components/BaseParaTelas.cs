using ProjetoSebo.controller;
using ProjetoSebo.dao;
using System;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public interface IBaseParaTela
    {
        void InitializeComponent();
    }

    public class BaseParaTela<TController> : Form, IBaseParaTela
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

        public virtual void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
