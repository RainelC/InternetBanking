
namespace InternetBanking.Core.Application.ViewModels.Products
{
    public class SaveProductViewModel
    {
        public int Id { get; set; }
        public int AccountID { get; set; }
        public string ProductType { get; set; }
        public decimal Amount { get; set; }
        public int UserID { get; set; }
    }
}
