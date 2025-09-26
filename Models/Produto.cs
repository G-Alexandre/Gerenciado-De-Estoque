using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estoque.Models
{
    [Table("produto")]
    public class Produto
    {
        [Key]
        [Column("id_produto")]
        public int Id { get; set; }

        [Required]
        [Column("nome")]
        [MaxLength(45)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [Column("preco", TypeName = "numeric(10,2)")]
        public decimal Preco { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; } = 0;
    }
}
