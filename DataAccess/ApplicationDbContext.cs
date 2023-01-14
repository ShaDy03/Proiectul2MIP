using Models;
using System.Data.Entity;

namespace DataAccess
{
    internal class ApplicationDbContext : DbContext
    {
        private const string CONNECTIONSTRING = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=Proiectul2DB;Integrated Security=true";
        public ApplicationDbContext() : base(CONNECTIONSTRING) 
        { }

        internal DbSet<User> User { get; set; }
        internal DbSet<Produs> Produs { get; set; }
        internal DbSet<Role> Role { get; set; }
        internal DbSet<Order> Order { get; set; }
    }
}
