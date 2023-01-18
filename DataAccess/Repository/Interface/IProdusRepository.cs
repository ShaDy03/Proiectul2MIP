using Models;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interface
{
    public interface IProdusRepository : IRepository<Produs>
    {
        Task Update(Produs produs);
    }
}
