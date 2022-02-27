using BookLibrary.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.UnitOfWork
{
    public interface IUnitOfWork
    { 
        IBookRepos _bookRepos { get; }
        ICatRepos _catRepos { get; }    
        IPubRepos _pubRepos { get; }
        IWriterRepos _writerRepos { get; }
        void Save();



    }
}
