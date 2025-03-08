namespace ProjetoProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto("TV", 2590.50, 50);
            Produto produto2 = new Produto("CELULAR", 1890.99, 60);
            Produto produto3 = new Produto("COMPUTADOR", 3698.98, 20);

            Console.WriteLine(produto1.getDetailProdut());
            Console.WriteLine(produto2.getDetailProdut());
            Console.WriteLine(produto3.getDetailProdut());

            Console.WriteLine("\n");

            Retangulo retangulo = new Retangulo();

            retangulo.Altura = 6.4;
            retangulo.Largura = 10.6;

            Console.WriteLine($"A área do retângulo é {retangulo.CalcularArea()}");
            Console.WriteLine($"O perímetro do retângulo é {retangulo.CalcularPerimetro()}");
        }
    }
}
