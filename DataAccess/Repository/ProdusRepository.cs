using DataAccess.Repository.Interface;
using Models;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProdusRepository : Repository<Produs>, IProdusRepository
    {
        private DbContext Context;

        private DbSet<Produs> ProdusDbSet;
        public ProdusRepository(DbContext dbContext) : base(dbContext) 
        { }

        public Task Update(Produs produs)
        {
            ProdusDbSet.AddOrUpdate(produs);
            return Task.CompletedTask;
        }
    }
}
