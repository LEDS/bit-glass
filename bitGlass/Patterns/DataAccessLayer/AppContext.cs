using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using bitGlass.Models.Faturamento;
using bitGlass.Models.Pessoas;

namespace bitGlass.Patterns.DataAccessLayer
{
    public class AppContext : DbContext
    {
        public AppContext() : base("AppContext")
        {
        }

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Telefonavel> Telefonaveis { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<HistoricoEstado> HistoricosEstados { get; set; }
        public DbSet<OrdemServico> OrdensServicos { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<TipoAro> TiposAros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}