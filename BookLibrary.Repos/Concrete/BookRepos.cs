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
    public class BookRepos : BaseRepository<Books>, IBookRepos
    {
        public BookRepos(Context db):base(db)
        {

        }

        public List<BooksSelect> GetBooks()
        {
            return Set().Select(x=> new BooksSelect
            {
                Id=x.Id,
                BookName=x.BookName,
                
            }).ToList();
        }

        public decimal BookValue(int id)
        {
            Books books = Find(id);
            return books.Stock * books.BookPrice;
        }

    }
}
