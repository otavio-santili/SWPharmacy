using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace SWPharmacy.Models
{ 
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int Id { get; set; }

        [StringLength(35)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Descrição: ")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Quantidade: ")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Preço: ")]
        public string Preco { get; set; }
    }
}
