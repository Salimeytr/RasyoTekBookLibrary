using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Ent.Entities
{
    public class Writers:Base
    {
        public Writers()
        {
            Books=new HashSet<Books>();

        }
        public  string  WriterName { get; set; }
        public string WriterContact { get; set; }

        public ICollection<Books> Books { get; set; }

    }
}
