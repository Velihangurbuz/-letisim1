using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Iletisim.Models
{
    public class Iletisimcontext : DbContext
    {
        public Iletisimcontext(DbContextOptions<Iletisimcontext> options) : base(options)
        {

        }
        public DbSet<Iletisims> iletisim { get; set; }

    }
}
