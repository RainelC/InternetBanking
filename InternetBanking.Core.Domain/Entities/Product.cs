namespace InternetBanking.Core.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int AccountID { get; set; }
        public string ProductType { get; set; }
        public decimal Amount { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
