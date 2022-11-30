using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace SWPharmacy.Models
{
    public enum Estado { RS, SC, PR, SP, RJ, ES, MG, MS, MT, GO, TO, MA, PA, PI, BA, SE, AL, RR, AM, AC };

    [Table("Clientes")]
    public class Cliente
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

        [Display(Name = "Data: ")]
        public DateTime Nascimento { get; set; }

        [StringLength(35)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nacionalidade: ")]
        public string Nacionalidade { get; set; }

        [Display(Name = "Estado: ")]
        public Estado Estado { get; set; }

        [StringLength(35)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Cidade: ")]
        public string Cidade { get; set; }

        [StringLength(45)]
        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Endereco: ")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Numero: ")]
        public int NumCasa { get; set; }

    }
}
