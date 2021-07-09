namespace Master
{
    public class Product
    {
        public int id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
