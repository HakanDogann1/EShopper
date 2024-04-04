using EShopper.BusinessLayer.Abstract;
using EShopper.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopper.BusinessLayer.Mapping;
using EShopper.SharedLayer;

namespace EShopper.BusinessLayer.Concrete
{
    public class GenericService<TCreate, TUpdate, TList, TEntity> : IGenericService<TCreate, TUpdate, TList, TEntity>
        where TCreate : class
        where TUpdate : class
        where TList : class
        where TEntity : class
    {
        private readonly RepositoryDal<TEntity> _repositoryDal;
        public GenericService(RepositoryDal<TEntity> repositoryDal)
        {
            _repositoryDal = repositoryDal;
        }
        public async Task<Response<TCreate>> CreateAsync(TCreate entity)
        {
            var newEntity = ObjectMapping.mapper.Map<TEntity>(entity);
            var value = await _repositoryDal.CreateAsync(newEntity);
           
            return new Response<TCreate>(SharedLayer.Enums.ReturnType.Ok,"İşlem başarılı",entity);
        }

        public Response<bool> DeleteAsync(int id)
        {
            var value = _repositoryDal.Delete(id);
            return new Response<bool>(SharedLayer.Enums.ReturnType.Ok,"",value);
        }

        public async Task<Response<IEnumerable<TList>>> GetAllAsync()
        {
            var value = await _repositoryDal.GetAllAsync();
            var newEntity = ObjectMapping.mapper.Map<List<TList>>(value);
            return new Response<IEnumerable<TList>>(SharedLayer.Enums.ReturnType.Ok, "İşlem başarılı", newEntity);
        }

        public async Task<Response<TList>> GetByIdAsync(int id)
        {
            var value = await _repositoryDal.GetByIdAsync(id);
            var newEntity = ObjectMapping.mapper.Map<TList>(value);
            return new Response<TList>(SharedLayer.Enums.ReturnType.Ok, "Başarılı", newEntity);
        }

        public Response<TUpdate> Update(TUpdate update)
        {
            var entity = ObjectMapping.mapper.Map<TEntity>(update);
            var value = _repositoryDal.Update(entity);
            var newEntity = ObjectMapping.mapper.Map<TUpdate>(value);
            return new Response<TUpdate>(SharedLayer.Enums.ReturnType.Ok, "Güncelleme başarılı", newEntity);
        }
    }
}
