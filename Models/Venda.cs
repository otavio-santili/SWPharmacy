using Microsoft.AspNetCore.Routing.Constraints;
using System.Drawing;

namespace SWPharmacy.Models
{
 //   public enum TipoPagamento {Dinheiro, Débito, Crédito, PIX};
    public class Venda
    {
        public int Id { get; set; }
        public int ClienteID { get; set; }
        public Cliente Clientes { get; set; }
        public int ProdutoID { get; set; }
        public Produto Produtos { get; set; }
        public int Quantidade { get; set; }
        public float ValorTotal { get; set; }
    //    public TipoPagamento TipoPagamento { get; set; }
    }
}
