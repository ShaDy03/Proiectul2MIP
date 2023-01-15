using DataAccess.Repository.Interface;
using Models;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace DataAccess.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private DbContext Context;

        private DbSet<User> UserDbSet;
        public UserRepository(DbContext dbContext) : base(dbContext) 
        {
            Context = dbContext;
            UserDbSet = Context.Set<User>();
        }

        public void Update(User user)
        {
            UserDbSet.AddOrUpdate(user);
        }
    }
}
