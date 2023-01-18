using Models;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using DataAccess.Repository.Interface;

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

        public Task Update(User user)
        {
            UserDbSet.AddOrUpdate(user);
            return Task.CompletedTask;
        }
    }
}
