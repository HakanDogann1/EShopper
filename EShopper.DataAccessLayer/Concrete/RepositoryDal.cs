using EShopper.DataAccessLayer.Abstract;
using EShopper.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DataAccessLayer.Concrete
{
    public class RepositoryDal<TEntity> : IRepositoryDal<TEntity> where TEntity : class
    {
        private readonly EShopperDbContext _context;

        public RepositoryDal(EShopperDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public bool Delete(int id)
        {
            var value = _context.Set<TEntity>().Find(id);
            try
            {
                _context.Set<TEntity>().Remove(value);
            }
            catch (Exception)
            {

                return false;
            }
            _context.SaveChanges();
            return true;
        }

        public async  Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var values = await _context.Set<TEntity>().ToListAsync();
            return values;
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            var value = await _context.Set<TEntity>().FindAsync(id);
            return value;
        }

        public TEntity Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            _context.SaveChanges();
            return entity;
        }

    }
}
