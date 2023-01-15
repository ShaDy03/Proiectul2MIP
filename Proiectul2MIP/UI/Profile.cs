using Models;
using System;
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
            if (Data.UserData.UserName.Equals(Data.OtherUser.UserName))
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
            UserNameLBL.Text = Data.OtherUser.UserName;
            RoleLBL.Text = Data.OtherUser.Role.Name;
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            User user = Data.UserData;
            user.IsDeleted = true;
            Data.DataBase.User.Update(user);
            this.Visible = false;
            new Login().Visible = true;
        }

        private void UPgradeRole_Click(object sender, EventArgs e)
        {
            User user = Data.OtherUser;
            switch(RoleProfileLBL.Text)
            {
                case "User":
                    user.RoleId = 2;
                    Data.DataBase.User.Update(user);
                    break;

                case "Administrator":
                    user.RoleId = 3;
                    Data.DataBase.User.Update(user); 
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

        private void DOWNgradeRole_Click(object sender, EventArgs e)
        {
            User user = Data.OtherUser;
            switch (RoleProfileLBL.Text)
            {
                case "Administrator":
                    user.RoleId = 1;
                    Data.DataBase.User.Update(user);
                    break;

                case "Owner":
                    user.RoleId = 2;
                    Data.DataBase.User.Update(user);
                    break;

                default:
                    return;
            }
        }
    }
}
