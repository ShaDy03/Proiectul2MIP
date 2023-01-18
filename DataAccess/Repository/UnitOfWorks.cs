using DataAccess.Repository.Interface;

namespace DataAccess.Repository
{
    public class UnitOfWorks : IUnitOfWorks
    {
        public static readonly UnitOfWorks Instance = new UnitOfWorks(new ApplicationDbContext());
        private readonly ApplicationDbContext _db;
        public IUserRepository User { get; private set; }
        public IRoleRepository Role { get; private set; }
        public IProdusRepository Produs { get; private set; }
        public IHistoryOrderRepository HistoryOrder { get; private set; }

        internal UnitOfWorks(ApplicationDbContext db)
        {
            _db = db;

            User = new UserRepository(_db);
            Role = new RoleRepository(_db);
            Produs = new ProdusRepository(_db);
            HistoryOrder = new HistoryOrderRepository(_db);
        }


        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
