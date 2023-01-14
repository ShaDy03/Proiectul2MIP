using DataAccess.Repository.Interface;

namespace DataAccess.Repository
{
    public class UnitOfWorks : IUnitOfWorks
    {
        public static readonly UnitOfWorks Instance = new UnitOfWorks(new ApplicationDbContext());
        private readonly ApplicationDbContext _db;
        public IUserRepository User { get; private set; }
        public IOrderRepository Order { get; private set; }
        public IRoleRepository Role { get; private set; }
        public IProdusRepository Produs { get; private set; }

        internal UnitOfWorks(ApplicationDbContext db)
        {
            _db = db;

            User = new UserRepository(_db);
            Order = new OrderRepository(_db);
            Role = new RoleRepository(_db);
            Produs = new ProdusRepository(_db);
        }


        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
