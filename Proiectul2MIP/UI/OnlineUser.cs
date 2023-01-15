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

        private void OnlineUser_Load(object sender, System.EventArgs e)
        {
            Data.ActualiseOnlineUsers();
            OnlineUsers.Items.Clear();
            OnlineUsers.Items.Add(GetOnlineUsers());
        }

        private void SendProfile_Click(object sender, System.EventArgs e)
        {
            try
            {
                int index = Int32.Parse(IndexBox.Text);
                if (index >= Data.OnlineUsers.Count)
                    throw new ArgumentException("Index is out of range");

                Data.OtherUser = Data.DataBase.User.GetFirstOrDefault(user => user.UserName == Data.OnlineUsers[index].UserName);
                this.Visible = false;
                new Profile().Visible = true;
            }
            catch (Exception ex)
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
