using BookLibrary.Dal;
using BookLibrary.Ent.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Base
    {
        Context _db;
        public BaseRepository(Context db)
        {
            _db=db;
        }
        public bool Create(T entity)
        {
            try
            {
                entity.UserId =10;
                entity.CreateTime = DateTime.Now;
                Set().Add(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                Set().Remove(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public T Find(int id)
        {
            return Set().Find(id);
        }

        public List<T> List()
        {
            return Set().ToList();
        }

        public DbSet<T> Set()
        {
            return _db.Set<T>();

        }

        public bool Update(T entity)
        {
            try
            {
                entity.UserId = 10;
                entity.UpdateTime = DateTime.Now;
                Set().Update(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
