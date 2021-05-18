using MySql.Data.EntityFramework;
using Orders;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace OrderApp
{

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderContext : DbContext
    {
        public OrderContext() : base("OrderDataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderContext>());
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}