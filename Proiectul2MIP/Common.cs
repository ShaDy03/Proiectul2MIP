﻿using DataAccess.Repository;
using Models;
using System.Collections.Generic;

namespace Proiectul2MIP
{
    public class Common
    {
        public static Common Instance = new Common(UnitOfWorks.Instance);

        public UnitOfWorks DataBase { get; private set; }
        public User UserData { get; set; }
        public User OtherUser { get; set; }
        public List<User> OnlineUsers { get; private set; }

        private Common(UnitOfWorks db)
        {
            DataBase = db;
        }

        public void ActualiseOnlineUsers()
        {
            OnlineUsers.AddRange(DataBase.User.GetAll(io => io.IsOnline == true));
            OnlineUsers.ForEach(user => user.Role = DataBase.Role.GetById(user.RoleId));
        }
    }
}
