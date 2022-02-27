using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Ent.Entities
{
    public class Books:Base
    {
        public int CategoryId { get; set; }
        public int PublisherId { get; set; }      
        public string? BookName { get; set; }     
        public string Writer { get; set; }
      
        public decimal BookPrice { get; set; }
        public int Stock { get; set; }
        [ForeignKey("CategoryId")]
        public Categories? Categories { get; set; }

        [ForeignKey("PublisherId")]
        public Publishers Publishers { get; set; }
    }
}
