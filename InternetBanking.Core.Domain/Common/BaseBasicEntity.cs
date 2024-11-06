namespace InternetBanking.Core.Domain.Common
{
    public class BaseBasicEntity
    {
        public int Id { get; set; }
        public string AccountID { get; set; }
        public decimal Amount { get; set; }
    }
}
