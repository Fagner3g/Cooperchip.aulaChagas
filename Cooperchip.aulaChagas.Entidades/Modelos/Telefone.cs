using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cooperchip.aulaChagas.Dados.Modelos
{
    public class Telefone
    {
        [Key]
        public int TelefoneId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string DDD { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [ForeignKey("TipoTelefone")]
        public int idTipoTelefone { get; set; }

        public virtual TipoTelefone TipoTelefone { get; set; }
    }
}
