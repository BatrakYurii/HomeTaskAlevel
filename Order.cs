namespace Master
{
    public class Order
    {
        public int id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
        public decimal Total { get; set; }
    }
}
