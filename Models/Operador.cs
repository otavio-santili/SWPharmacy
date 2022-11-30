using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace SWPharmacy.Models
{
    public enum TipoPermissao { Vendedor, Caixa, Gerente, TI };

    [Table("Operadores")]
    public class Operador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int Id { get; set; }

        [StringLength(35)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }


        public TipoPermissao TipoPermissao { get; set; }
    }
}
