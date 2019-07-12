﻿using ProjetoSebo.bean;

namespace ProjetoSebo.model
{
    public class LocalModel : BaseParaModel
    {
        public LocalModel(Local local)
        {
            this.Id = local.Id;
            this.Descricao = local.Descricao;
        }

        public Local ConverterParaBean()
        {
            Local local = new Local
            {
                Id = this.Id,
                Descricao = this.Descricao
            };

            return local;
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}