namespace SWPharmacy.Models
{
    public enum Estado { RS, SC, PR, SP, RJ, ES, MG, MS, MT, GO, TO, MA, PA, PI, BA, SE, AL, RR, AM, AC };

    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime Nascimento { get; set; }
        public string Nacionalidade { get; set; }
        public Estado Estado { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public int NumCasa { get; set; }

        public ICollection<Venda> Vendas { get; set; }
    }
}
