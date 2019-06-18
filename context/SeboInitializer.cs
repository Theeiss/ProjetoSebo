using ProjetoSebo.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSebo.dao
{
    public class SeboInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SeboContext>
    {
        protected override void Seed(SeboContext context)
        {
            var usuarios = new List<Usuario>
            {
            new Usuario{Login="moacir",Senha="urso"},
            new Usuario{Login="theiss",Senha="gtheiss"},
            new Usuario{Login="linguica",Senha="apertarcu"}
            };

            usuarios.ForEach(usuario => context.Usuarios.Add(usuario));
            context.SaveChanges();
        }
    }
}
