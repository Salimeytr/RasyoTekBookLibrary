using BookLibrary.Ent.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Ent
{
    public class Publishers:Base
    {
        public Publishers()
        {
            Books = new HashSet<Books>();
        }
        public string PublisherName  { get; set; }
        public string ContactName { get; set; }
        public ICollection<Books> Books { get; set; }
    }
}
