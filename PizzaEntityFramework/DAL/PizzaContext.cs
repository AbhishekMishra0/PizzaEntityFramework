using System;
using System.Data.Entity;
using System.Linq;

namespace PizzaEntityFramework.DAL
{
    public class PizzaContext : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PizzaEntityFramework.DAL.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public PizzaContext() : base("PizzaOrderDb") // alias name of the db  
        {
        }
        //public PizzaContext() : base("name = test") // it will look for connection string named test in the configuration file and from there it'll will take the name of the db
        //{
        //}
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> orders { get; set; }
    }

}