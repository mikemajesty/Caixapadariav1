
namespace Model
{
    public class ValorComComanda
    {
       
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdComanda { get; set; }
        public int IdProduto { get; set; }
        public double PrecoTotal { get; set; }
        public int Quantidade { get; set; }
        public string CodigoProd { get; set; }

     
        public override string ToString()
        {
            return string.Format("Nome: {0} - Quantidade: {1}x - Preço Total: {2}",

                    Nome,
    Quantidade,
    PrecoTotal.ToString("C") + "\n");

        }
      
    }
}
