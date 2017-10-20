namespace Cooperchip.aulaChagas.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbTipoProduto")]
    public partial class tbTipoProduto
    {
        [Key]
        public int cod_tipo { get; set; }

        [StringLength(20)]
        public string descricao { get; set; }
    }
}
