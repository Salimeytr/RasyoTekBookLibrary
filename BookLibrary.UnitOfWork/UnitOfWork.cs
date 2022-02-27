using BookLibrary.Dal;
using BookLibrary.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        Context _db;
        public IBookRepos _bookRepos { get;private set; }

        public ICatRepos _catRepos {get;private set; }

        public IPubRepos _pubRepos { get;private set; }

        public IWriterRepos _writerRepos { get;private set; }

        public void Save()
        {
            _db.SaveChanges();
        }

        public UnitOfWork(Context db,ICatRepos catRepos,IBookRepos bookRepos ,IPubRepos pubRepos, IWriterRepos writerRepos)
           
        {
            _db = db;
            _catRepos = catRepos;
            _bookRepos = bookRepos;
            _writerRepos = writerRepos;
            _pubRepos= pubRepos;

        }
    }
}
