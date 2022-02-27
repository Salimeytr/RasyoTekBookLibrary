using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.DTO
{
    public class BooksList
    {
        public int Id  { get; set; }
        public string BookName  { get; set; }
        public string Writer  { get; set; }
        public string  PublisherName { get; set; }

        public decimal Value  { get; set; }
    }
}
