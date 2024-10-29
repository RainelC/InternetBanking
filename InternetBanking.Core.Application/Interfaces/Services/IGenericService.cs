namespace InternetBanking.Core.Application.Interfaces.Services
{
    public interface IGenericService<SaveViewModel, ViewModel>
        where ViewModel : class
        where SaveViewModel : class        
    {
        Task Add(SaveViewModel vm);
        Task Update(SaveViewModel vm);
        Task Delete(int id);
        Task<SaveViewModel> GetById(int id);
        Task<List<ViewModel>> GetAll();
    }
}
