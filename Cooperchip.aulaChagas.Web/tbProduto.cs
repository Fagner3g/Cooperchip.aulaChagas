namespace Cooperchip.aulaChagas.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbProduto")]
    public partial class tbProduto
    {
        [Key]
        public int cod_produto { get; set; }

        [Required]
        [StringLength(20)]
        public string descricao { get; set; }

        public int tipo { get; set; }

        public decimal? preco_venda { get; set; }

        public decimal? preco_compra { get; set; }

        public int cod_fornecedor { get; set; }

        [StringLength(20)]
        public string fabricante { get; set; }

        public int cod_tipo { get; set; }
    }
}
