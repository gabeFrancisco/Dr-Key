namespace Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public long BarCode { get; set; }
        public decimal CostPrice { get; set; }
        public string NCM { get; set; }

        public Product() { }

    }
}
