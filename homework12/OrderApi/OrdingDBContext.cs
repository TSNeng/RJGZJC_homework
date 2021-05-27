using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApi
{
    public class OrdingDBContext: DbContext
    {
        public OrdingDBContext(DbContextOptions<OrdingDBContext> options)
            :base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}
