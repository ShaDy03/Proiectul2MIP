using Models;

namespace DataAccess.Repository.Interface
{
    public interface IUserRepository : IRepository<User>
    {
        void Update(User user);
    }
}
