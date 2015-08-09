

namespace Model
{
   public  class Produto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int Categoria { get; set; }
        public double PrecoCompra { get; set; }
        public double PrecoVenda { get; set; }
        public string Descricao { get; set; }
        public decimal Porcentagem { get; set; }
       
        /////////////////////
        public int Quantidade { get; set; }
        public int QtdMinima { get; set; }
        public int QtdMaxima { get; set; }
       

    
       
    }
}
