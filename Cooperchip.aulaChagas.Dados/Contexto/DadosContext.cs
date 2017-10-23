using Cooperchip.aulaChagas.Dados.Modelos;
using System.Data.Entity;


namespace Cooperchip.aulaChagas.Dados.Contexto
{
    public class DadosContext : DbContext
    {
        public DadosContext()
            : base("CoperchipDB")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Telefone> Telefone { get; set; }

        public DbSet<TipoTelefone> TipoTelefone { get; set; }
    }
}
