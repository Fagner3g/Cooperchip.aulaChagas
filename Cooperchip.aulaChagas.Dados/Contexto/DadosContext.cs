using Cooperchip.aulaChagas.Dados.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperchip.aulaChagas.Dados.Contexto
{
    public class DadosContext : DbContext
    {
        public DadosContext()
            : base("DefaultConnection")
        {

        }


        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Telefone> Telefone { get; set; }

        public DbSet<TipoTelefone> TipoTelefone { get; set; }
    }
}
