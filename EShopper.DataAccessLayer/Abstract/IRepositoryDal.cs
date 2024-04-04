using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DataAccessLayer.Abstract
{
    public interface IRepositoryDal<TEntity> where TEntity : class
    {
        public Task<TEntity> CreateAsync(TEntity entity);
        public TEntity Update(TEntity entity);
        public bool Delete(int id);
        public Task<TEntity> GetByIdAsync(int id);
        public Task<IEnumerable<TEntity>> GetAllAsync();
    }
}
