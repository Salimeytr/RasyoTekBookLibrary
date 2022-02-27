using BookLibrary.Core;
using BookLibrary.DTO;
using BookLibrary.Ent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repos.Abstract
{
    public interface ICatRepos:IBaseRepository<Categories>
    {
        List<CategoriesSelect> GetCategoriesSelects();
    }
}
