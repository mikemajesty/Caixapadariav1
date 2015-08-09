

namespace Model
{
    public class Venda
    {
        public int Id { get; set; }
        public decimal VendaTotal { get; set; }
        public decimal LucroTotal { get; set; }
        public string Data { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoPagamento { get; set; }
    }
}
