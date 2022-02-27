using BookLibrary.Core;
using BookLibrary.Dal;
using BookLibrary.DTO;
using BookLibrary.Ent;
using BookLibrary.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repos.Concrete
{
    public class PubRepos:BaseRepository<Publishers>,IPubRepos
    {
        public PubRepos(Context db):base(db)
        {

        }

        public List<PublishersSelect> GetPublishersSelect()
        {
            return Set().Select(x => new PublishersSelect
            {
                Id = x.Id,
                PublisherName =x.PublisherName
                
            }).ToList();
        }
        
    }
}
