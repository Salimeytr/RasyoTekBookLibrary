using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Core
{
    public interface IBaseRepository<T> where T: class
    {
        bool Update(T entity);
        bool Delete(T entity);
        bool Create(T entity);
        T Find(int id);
        List<T> List();
        DbSet<T> Set();

    }
}
