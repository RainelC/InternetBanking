namespace InternetBanking.Core.Domain.Entities
{
    public class Beneficiary
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AccountID { get; set; }
    }
}
