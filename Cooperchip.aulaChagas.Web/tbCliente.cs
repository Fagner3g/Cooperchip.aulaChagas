namespace Cooperchip.aulaChagas.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbCliente")]
    public partial class tbCliente
    {
        [Key]
        public int cod_cli { get; set; }

        [StringLength(20)]
        public string Nome_cli { get; set; }

        [StringLength(20)]
        public string Endereco { get; set; }

        public decimal? salario { get; set; }

        [StringLength(20)]
        public string bairro { get; set; }

        [StringLength(20)]
        public string cidade { get; set; }

        [StringLength(20)]
        public string uf { get; set; }
    }
}
