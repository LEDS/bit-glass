using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using bitGlass.Models.Pessoas;

namespace bitGlass.Patterns.DataAccessLayer
{
    public class AdminContext : DbContext
    {
        public AdminContext() : base("AdminContext")
        {
        }

        public DbSet<UsuarioLogin> Logins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}