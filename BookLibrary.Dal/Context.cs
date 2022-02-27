using BookLibrary.Ent;
using BookLibrary.Ent.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Dal
{
    public class Context:DbContext 
    {
        public Context(DbContextOptions<Context>op):base(op)
        {

        }
        public DbSet<Books> Books { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Publishers> Publishers { get; set; }
        public DbSet<Writers> Writers { get; set; }


    }


}
