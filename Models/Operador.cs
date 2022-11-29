namespace SWPharmacy.Models
{
    public enum TipoPermissao { Vendedor, Caixa, Gerente, TI };
  
    public class Operador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public TipoPermissao TipoPermissao { get; set; }
    }
}
