namespace Domain.Entities
{
    public class Key
    {
        public int Id { get; set; }
        public string Manufactor { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public decimal Price { get; set; }
        public string Buttons { get; set; }
        public int Quantity { get; set; }
        public string ServiceType { get; set; }
        public string Image { get; set; }
        public string Observation { get; set; }

        public Key() { }

        public void AddQuantity()
        {
            this.Quantity += 1;
        }

        public void SubtractQuantity()
        {
            this.Quantity -= 1;
        }
    }
}
