using DataAccess.Repository.Interface;
using Models;
using System.Data.Entity;

namespace DataAccess.Repository
{
    public class ProdusRepository : Repository<Produs>, IProdusRepository
    {
        public ProdusRepository(DbContext dbContext) : base(dbContext) 
        { }
    }
}
