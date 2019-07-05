﻿using ProjetoSebo.controller;
using ProjetoSebo.dao;
using ProjetoSebo.error;
using ProjetoSebo.model;
using System;
using System.Windows.Forms;

namespace ProjetoSebo.views.components
{
    public interface IBaseParaTela
    {
        void TratarConsistencia(ResultadoOperacao retorno);
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
            this.Controller.Tela = this;

            InitializeComponent();
        }

        protected virtual void InitializeComponent()
        {
        }

        public virtual void TratarConsistencia(ResultadoOperacao retorno)
        {
            throw new NotImplementedException();
        }
    }
}
