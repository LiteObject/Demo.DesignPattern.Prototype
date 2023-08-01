namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new() { Id = 1, Name = "Product One", Price = 1.99m, Description = "Product one description." };

            Product clonedProduct = product.Clone();
            clonedProduct.Id = 2;
            clonedProduct.Name = "Product Two";

            Console.WriteLine($"Original: Id={product.Id}, Name={product.Name}, Description={product.Description}");
            Console.WriteLine($"Cloned:   Id={clonedProduct.Id}, Name={clonedProduct.Name}, Description={clonedProduct.Description}");

            Console.ReadKey();
        }
    }
}