namespace ConsoleApp
{
    public class Product : IPrototype<Product>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public Product Clone()
        {
            // The MemberwiseClone() method creates a new object that is a shallow copy of the original object.
            return (Product)this.MemberwiseClone();
        }
    }
}