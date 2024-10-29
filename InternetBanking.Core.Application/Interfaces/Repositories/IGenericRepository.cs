namespace InternetBanking.Core.Application.Interfaces.Repositories
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        Task AddAsync(Entity entity);
        Task UpdateAsync(Entity entity);
        Task DeleteAsync(Entity entity);
        Task<Entity> GetByIdAsync(int id);
        Task<List<Entity>> GetAllAsync();

    }
}
