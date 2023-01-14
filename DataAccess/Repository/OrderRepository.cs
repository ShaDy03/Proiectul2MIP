using DataAccess.Repository.Interface;
using Models;
using System.Data.Entity;

namespace DataAccess.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext context) : base(context)
        { }
    }
}
