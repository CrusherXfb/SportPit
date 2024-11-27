namespace SportPit.Models
{

    public class User
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required List<Product> Products { get; set; }
    }
}
