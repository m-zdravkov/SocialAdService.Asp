namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ServiceDbContext : DbContext
    {
        public static ServiceDbContext lastContext { get; private set; }
        // Your context has been configured to use a 'DBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Model.DBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBContext' 
        // connection string in the application configuration file.
        public ServiceDbContext()
            : base("name=DBContext")
        {
            lastContext = this;
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Ad> Ads { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
    }
}