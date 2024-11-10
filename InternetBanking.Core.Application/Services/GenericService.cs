using AutoMapper;
using InternetBanking.Core.Application.Interfaces.Repositories;
using InternetBanking.Core.Application.Interfaces.Services;

namespace InternetBanking.Core.Application.Services
{
    public class GenericService<SaveViewModel, ViewModel, Entity> : IGenericService<SaveViewModel, ViewModel, Entity>
        where SaveViewModel : class
        where ViewModel : class
        where Entity : class
    {
        private readonly IGenericRepository<Entity> _genericRepository;
        private readonly IMapper _mapper;
        public GenericService(IGenericRepository<Entity>  repository, IMapper mapper)
        {
            _genericRepository = repository;
            _mapper = mapper;
        }
        public async Task<SaveViewModel> Add(SaveViewModel vm)
        {
            Entity entity = _mapper.Map<Entity>(vm);
            entity = await _genericRepository.AddAsync(entity);

            SaveViewModel svm = _mapper.Map<SaveViewModel>(entity);
            return svm;
        }

        public async Task Delete(int id)
        {
            Entity entity = await _genericRepository.GetByIdAsync(id);
            await _genericRepository.DeleteAsync(entity);
        }

        public async Task<List<ViewModel>> GetAll()
        {
            var entityList = await _genericRepository.GetAllAsync();
            return _mapper.Map<List<ViewModel>>(entityList);
        }

        public async Task<SaveViewModel> GetById(int id)
        {
            Entity entity = await _genericRepository.GetByIdAsync(id);
            SaveViewModel vm = _mapper.Map<SaveViewModel>(entity);
            return vm;
        }

        public async Task Update(SaveViewModel vm, int Id)
        {
            Entity entity = _mapper.Map<Entity>(vm);
            await _genericRepository.UpdateAsync(entity, Id);
        }
    }
}
