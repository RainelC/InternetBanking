namespace InternetBanking.Core.Application.Interfaces.Services
{
    public interface IGenericService<SaveViewModel, ViewModel, Entity>
        where ViewModel : class
        where SaveViewModel : class
        where Entity : class
    {
        Task<SaveViewModel> Add(SaveViewModel vm);
        Task Update(SaveViewModel vm, int Id);
        Task Delete(int id);
        Task<SaveViewModel> GetById(int id);
        Task<List<ViewModel>> GetAll();
    }
}
