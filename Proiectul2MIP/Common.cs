using DataAccess.Repository;
using Models;

namespace Proiectul2MIP
{
    public class Common
    {
        public static Common Instance = new Common(UnitOfWorks.Instance);

        public UnitOfWorks DataBase { get; private set; }
        public User UserData { get; set; }

        private Common(UnitOfWorks db)
        {
            DataBase = db;
        }
    }
}
