using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperchip.aulaChagas.Dados.Modelos
{
    public class Telefone
    {
        public int TelefoneId { get; set; }

        public string DDD { get; set; }

        public string Numero { get; set; }

        public virtual TipoTelefone TipoTelefone { get; set; }
    }
}
