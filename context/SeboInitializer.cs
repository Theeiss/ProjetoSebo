using ProjetoSebo.model;
using System.Collections.Generic;

namespace ProjetoSebo.dao
{
    public class SeboInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SeboContext>
    {
        protected override void Seed(SeboContext context)
        {
            var usuarios = new List<UsuarioModel>
            {
            new UsuarioModel{Login="moacir",Senha="urso"},
            new UsuarioModel{Login="theiss",Senha="gtheiss"},
            };

            usuarios.ForEach(usuario => context.Usuarios.Add(usuario));

            var tiposProduto = new List<TipoProdutoModel>
            {
                new TipoProdutoModel{Descricao="Livro"},
                new TipoProdutoModel{Descricao="DVD"},
                new TipoProdutoModel{Descricao="CD"},
            };

            tiposProduto.ForEach(tipo => context.TiposProduto.Add(tipo));

            context.SaveChanges();
        }
    }
}
