using InternetBanking.Core.Application.ViewModels.Products;
using InternetBanking.Core.Domain.Entities;

namespace InternetBanking.Core.Application.Interfaces.Services
{
    public interface IProductService : IGenericService<SaveProductViewModel, ProductViewModel, Product>
    {
    }
}
