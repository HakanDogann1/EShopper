using EShopper.SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.Abstract
{
    public interface IGenericService<TCreate, TUpdate, TList, TEntity>
       where TEntity : class
       where TCreate : class
       where TUpdate : class
       where TList : class
    {
        public Task<Response<TCreate>> CreateAsync(TCreate entity);
        public Response<TUpdate> Update(TUpdate entity);
        public Response<bool> DeleteAsync(int id);
        public Task<Response<TList>> GetByIdAsync(int id);
        public Task<Response<IEnumerable<TList>>> GetAllAsync();

    }
   
}
