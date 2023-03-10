using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proiectul2MIP.UI
{
    public partial class OnlineUser : Form
    {
        public OnlineUser()
        {
            InitializeComponent();
            OnlineUsers.Items.Clear();
            Data.ActualiseOnlineUsers();
            foreach (var user in GetOnlineUsers())
            {
                OnlineUsers.Items.Add(user);
            }
        }

        private List<string> GetOnlineUsers()
        {
            List<string> users = new List<string>();
            var index = 0;
            foreach(var user in Data.OnlineUsers)
            {
                users.Add($"{index}) {user.UserName}");
                index++;
            }
            return users;
        }

        private void SendProfile_Click(object sender, System.EventArgs e)
        {
            try
            {
                int index = Int32.Parse(IndexBox.Text);
                if (index >= Data.OnlineUsers.Count)
                    throw new ArgumentException("Index is out of range");

                Data.OtherUser = Data.DataBase.User.GetFirstOrDefault(user => user.UserName == Data.OnlineUsers[index].UserName).Result;
                Data.OtherUser.Password = string.Empty;
                this.Visible = false;
                new Profile().Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("This value in Indexbox is Invalide");
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Shop().Visible = true;
        }
    }
}
