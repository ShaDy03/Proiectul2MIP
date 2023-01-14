using DataAccess.Repository.Interface;
using Models;
using System.Data.Entity;

namespace DataAccess.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext dbContext) : base(dbContext) 
        { }
    }
}
