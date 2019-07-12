using MySql.Data.EntityFramework;
using ProjetoSebo.model;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjetoSebo.dao
{
    public class RemoveModelSufixTableNameConvention : IStoreModelConvention<EntitySet>, IConvention
    {
        public RemoveModelSufixTableNameConvention()
        {
        }

        //
        public virtual void Apply(EntitySet item, DbModel model)
        {
            item.Name = item.Name.Replace("Model", "");
        }
    }

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class SeboContext : DbContext
    {
        public SeboContext() : base("MyContext")
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<TipoProdutoModel> TiposProduto { get; set; }
        public DbSet<LocalModel> Locais { get; set; }
        public DbSet<LocalProdutoModel> LocaisProduto { get; set; }
        public DbSet<VendaModel> Vendas { get; set; }
        public DbSet<ClienteModel> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Add<RemoveModelSufixTableNameConvention>();
        }
    }
}
