using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace SWPharmacy.Models
{
    [Table("Vendedores")]
    public class Vendedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int Id { get; set; }

        [StringLength(35)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nome: ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "CPF: ")]
        public string Cpf { get; set; }

        [Display(Name = "Data de nascimento: ")]
        public DateTime Nascimento { get; set; }

        [StringLength(35)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nacionalidade: ")]
        public string Nacionalidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Estado: ")]
        public string Estado { get; set; }

        [StringLength(35)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Cidade: ")]
        public string Cidade { get; set; }

        [StringLength(35)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Endereço: ")]
        public string Endereco { get; set; }

        [StringLength(35)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Numero: ")]
        public int NumCasa { get; set; }
    }
}
