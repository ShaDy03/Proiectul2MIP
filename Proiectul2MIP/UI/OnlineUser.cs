using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
            OnlineUsers.Items.Add(GetOnlineUsers());
        }

        private void SendProfile_Click(object sender, System.EventArgs e)
        {
            try
            {
                int index = Int32.Parse(IndexBox.Text);
                Data.OtherUser = Data.DataBase.User.GetFirstOrDefault(user => user.UserName == Data.OnlineUsers[index].UserName);
                this.Visible = false;
                new Profile().Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("This value in Indexbox is Invalide");
            }
        }
    }
}
