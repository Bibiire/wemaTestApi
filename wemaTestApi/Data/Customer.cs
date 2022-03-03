namespace wemaTestApi.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string State { get; set; }
        public string Lga { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


    }
}
