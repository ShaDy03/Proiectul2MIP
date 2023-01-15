using DataAccess.Repository.Interface;
using Models;
using System.Data.Entity;

namespace DataAccess.Repository
{
    public class HistoryOrderRepository : Repository<HistoryOrder>, IHistoryOrderRepository
    {
        public HistoryOrderRepository(DbContext context) : base(context)
        {
        }
    }
}
