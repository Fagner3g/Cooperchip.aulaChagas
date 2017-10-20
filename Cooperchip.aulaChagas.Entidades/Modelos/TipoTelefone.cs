using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooperchip.aulaChagas.Dados.Modelos
{
    public class TipoTelefone
    {
        [Key]
        public int TipoTelefoneId { get; set; }
        [Display(Name ="Tipo de Telefone")]
        [Required(ErrorMessage ="Tipo de Telefone é requerido.")]
        [MaxLength(12, ErrorMessage = "Máximo de caracter permitido: 12")]
        [MinLength(2, ErrorMessage = "Mínimo de caracter permitido: 2")]
        public string Descricao { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data inválida.")]
        public DateTime Data { get; set; }
    }
}
