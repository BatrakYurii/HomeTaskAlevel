namespace Master
{
    public class UserAddress
    {
        public int id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string CountryCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
