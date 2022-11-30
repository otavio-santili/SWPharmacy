using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace SWPharmacy.Models
{
    public enum TipoPagamento {Dinheiro, Débito, Crédito, PIX};

    [Table("Vendas")]
    public class Venda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nome: ")]
        public int ClienteID { get; set; } 
        public Cliente Clientes { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Produto: ")]
        public int ProdutoID { get; set; } 
        public Produto Produtos { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Quantidade: ")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Valor total: ")]
        public float ValorTotal { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Tipo de pagamento: ")]
        public TipoPagamento TipoPagamento { get; set; }
    }
}
