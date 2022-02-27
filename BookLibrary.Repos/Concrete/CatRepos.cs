using BookLibrary.Core;
using BookLibrary.Dal;
using BookLibrary.DTO;
using BookLibrary.Ent.Entities;
using BookLibrary.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repos.Concrete
{
    public class CatRepos:BaseRepository<Categories>,ICatRepos
    {
        public CatRepos(Context db):base(db)
        {

        }

        public List<CategoriesSelect> GetCategoriesSelects()
        {
            return Set().Select(x => new CategoriesSelect 
            {
                Id = x.Id,
                CategoryName = x.CategoryName

            }).ToList();
        }
    }
}
