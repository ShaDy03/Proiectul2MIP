using System;
using System.Windows.Forms;

namespace Proiectul2MIP.UI
{
    public partial class ShowAllUsers : Form
    {
        public ShowAllUsers()
        {
            InitializeComponent();
            AllUsers.Items.Clear();
            var i = 1;
            foreach(var user in Data.OnlineUsers)
            {
                AllUsers.Items.Add($"{i}) {user.UserName} {user}");
            }
        }

        private void SendProfile_Click(object sender, EventArgs e)
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
            Data.OtherUser = null;
            this.Visible = false;
            new Shop().Visible = true;
        }
    }
}
