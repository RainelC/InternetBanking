using InternetBanking.Core.Domain.Common;
using System.Net.Http.Headers;

namespace InternetBanking.Core.Domain.Entities
{
    public class User
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Cedula { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public bool IsActivate { get; set; }
        public List<Product> Products { get; set; }

    }
}
