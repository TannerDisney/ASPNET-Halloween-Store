using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Halloween_Store.Models;

namespace Halloween_Store.Data
{
    /// <summary>
    /// The database context for Costumes
    /// </summary>
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        { }

        public DbSet<Costume> Costumes { get; set; }
    }
}
