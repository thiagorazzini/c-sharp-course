using System.Globalization;
namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            
            
            Console.WriteLine("Entre os dados do Produto");
            Console.Write("Nome: ");

            product.Name = Console.ReadLine();

            Console.Write("Preço: ");
            product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            product.Quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {product}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int addproducts = int.Parse( Console.ReadLine());
            product.AddProducts(addproducts);

            Console.WriteLine($"Dados atualizados: {product}");




            Console.Write("Digite o número de produtos a ser removidos do estoque: ");
            int removeProducts = int.Parse(Console.ReadLine());
            product.RemoveProducts(removeProducts);

            Console.Write($"Dados atualizados: {product}");


        }
    }
}