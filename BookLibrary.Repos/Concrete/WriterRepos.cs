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
    public class WriterRepos : BaseRepository<Writers>, IWriterRepos
    {
        public WriterRepos(Context db):base(db)
        {

        }
        public List<WritersSelect> GetWritersSelects()
        {
            return Set().Select(x => new WritersSelect
            {
                Id = x.Id,
                WriterName = x.WriterName,
                WriterContact=x.WriterContact

            }).ToList();

        }
    }
}
