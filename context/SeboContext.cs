using MySql.Data.EntityFramework;
using ProjetoSebo.model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoSebo.dao
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class SeboContext : DbContext
    {
        public SeboContext() : base("MyContext")
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoProduto> TiposProduto { get; set; }
        public DbSet<LocalProduto> LocaisProduto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
