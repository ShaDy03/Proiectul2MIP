using Models;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interface
{
    public interface IUserRepository : IRepository<User>
    {
        Task Update(User user);
    }
}
