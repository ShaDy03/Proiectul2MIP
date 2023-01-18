using Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proiectul2MIP.UI
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            UserNameProfileLBL.Text = Data.OtherUser.UserName;
            RoleProfileLBL.Text = Data.OtherUser.Role.Name;
            if (Data.UserData.UserName == Data.OtherUser.UserName)
            {
                DeleteAccount.Enabled = true;
                DeleteAccount.Visible = true;
            }
            else
            {
                DeleteAccount.Enabled = false;
                DeleteAccount.Visible = false;
            }

            if(Data.UserData.RoleId != 2 || Data.UserData.RoleId != 3)
            {
                BlockedAccount.Enabled = false;
                BlockedAccount.Visible = false;
                UPgradeRole.Enabled = false;
                UPgradeRole.Visible = false;
                DOWNgradeRole.Enabled = false;
                DOWNgradeRole.Visible = false;
            }
            else
            {
                if(Data.UserData.RoleId == 3)
                {
                    BlockedAccount.Enabled = true;
                    BlockedAccount.Visible = true;
                    UPgradeRole.Enabled = true;
                    UPgradeRole.Visible = true;
                    DOWNgradeRole.Enabled = true;
                    DOWNgradeRole.Visible = true;
                }
                else
                {
                    UPgradeRole.Enabled = false;
                    UPgradeRole.Visible = false;
                    DOWNgradeRole.Enabled = false;
                    DOWNgradeRole.Visible = false;
                    if (Data.UserData.RoleId == Data.OtherUser.RoleId)
                        BlockedAccount.Enabled = false;
                    else 
                        BlockedAccount.Enabled = true;
                }
            }
            
            if (Data.OtherUser.RoleId == 4)
            {
                ProfileBlockedLBL.Text = "Account Blocked: YES";
                ProfileBlockedLBL.BackColor = Color.Red;
            }
            else
            {
                ProfileBlockedLBL.Text = "Account Blocked: NO";
                ProfileBlockedLBL.BackColor = Color.Lime;
            }

            if (Data.OtherUser.IsDeleted)
            {
                ProfileDeletedLBL.Text = "Account Deleted: YES";
                ProfileBlockedLBL.BackColor = Color.Red;
            }
            else
            {
                ProfileDeletedLBL.Text = "Account Deleted: NO";
                ProfileBlockedLBL.BackColor = Color.Lime;
            }
        }
        
        private void DeleteAccount_ClickAsync(object sender, EventArgs e)
        {
            User user = Data.UserData;
            user.IsDeleted = true;
            user.IsOnline = false;
            Data.DataBase.User.Update(user).Wait();
            this.Visible = false;
            new Login().Visible = true;
        }

        private void UPgradeRole_ClickAsync(object sender, EventArgs e)
        {
            User user = Data.OtherUser;
            switch(RoleProfileLBL.Text)
            {
                case "User":
                    user.RoleId = 2;
                    Data.DataBase.User.Update(user).Wait();
                    break;

                case "Administrator":
                    user.RoleId = 3;
                    Data.DataBase.User.Update(user).Wait(); 
                    break;

                default:
                    return;
            }
        }

        private void BlockedAccount_Click(object sender, EventArgs e)
        {
            User user = Data.OtherUser;
            if (user.RoleId == (int)RoleEnum.Blocked)
                user.RoleId = 1;

            if(user.RoleId < (int)RoleEnum.Blocked)
                user.RoleId = 4;

            Data.DataBase.User.Update(user);
        }

        private void DOWNgradeRole_ClickAsync(object sender, EventArgs e)
        {
            User user = Data.OtherUser;
            switch (RoleProfileLBL.Text)
            {
                case "Administrator":
                    user.RoleId = 1;
                    Data.DataBase.User.Update(user).Wait();
                    break;

                case "Owner":
                    user.RoleId = 2;
                    Data.DataBase.User.Update(user).Wait();
                    break;

                default:
                    return;
            }
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            Data.OtherUser = null;
            Data.UserData.IsOnline = false;
            Data.DataBase.User.Update(Data.UserData).Wait();
            this.Visible = false;
            new Login().Visible = true;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Data.OtherUser = null;
            this.Visible = false;
            new Shop().Visible = true;
        }
    }
}
