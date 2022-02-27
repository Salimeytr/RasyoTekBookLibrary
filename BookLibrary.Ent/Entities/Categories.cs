using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Ent.Entities
{
    public class Categories:Base
    {
        public Categories()
        {
            Books= new HashSet<Books>();

        }
        public string CategoryName { get; set; }
        public ICollection<Books>  Books { get; set; }

    }
}
