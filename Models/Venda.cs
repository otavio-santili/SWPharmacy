using Microsoft.AspNetCore.Routing.Constraints;

namespace SWPharmacy.Models
{
    public enum TipoPagamento {Dinheiro, Débito, Crédito, PIX};
    public class Venda
    {
        public int Id { get; set; }
        public Cliente Clientes { get; set; }
        public Produto Produtos { get; set; }
        public int Quantidade { get; set; }
        public float ValorTotal { get; set; }
        public TipoPagamento TipoPagamento { get; set; }

    }
}
