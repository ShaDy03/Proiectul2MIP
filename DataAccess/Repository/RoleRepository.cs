using DataAccess.Repository.Interface;
using Models;
using System.Data.Entity;

namespace DataAccess.Repository
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(DbContext dbContext) : base(dbContext) 
        { }
    }
}
