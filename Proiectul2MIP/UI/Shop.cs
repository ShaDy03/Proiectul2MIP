using Models;
using System.Windows.Forms;

namespace Proiectul2MIP.UI
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, System.EventArgs e)
        {
            if (Data.UserData.Role.Name.Equals(RoleEnum.Owner.ToString()) || Data.UserData.Role.Name.Equals(RoleEnum.Administrator.ToString()))
                DisabledOrEnabledAdminCommand(true);
            else
                DisabledOrEnabledAdminCommand(false);
        }

        private void DisabledOrEnabledAdminCommand(bool value)
        {
            UserNameLBL.Text = Data.UserData.UserName;
            RoleLBL.Text = Data.UserData.Role.Name;
            ShowUsersBtn.Enabled = value;
            ShowUsersBtn.Visible = value;
            AddProdusToShopBtn.Enabled = value;
            AddProdusToShopBtn.Visible = value;
            UserOnlineBtn.Enabled = value;
            UserOnlineBtn.Visible = value;
        }

        private void ShowShoppingBtn_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            //TODO: P.claudiu MyShop true;
        }

        private void HistoryShoppingBtn_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            //TODO: P.claudiu MyHistory true;
            //If Owner -> show all history.
        }

        private void UserOnlineBtn_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            //TODO: P.claudiu Users Online true;
        }

        private void MyProfileBtn_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            //TODO: P.claudiu MyProfile true;
            //Delete Account, if i am admin, blocked account, if owner, blocked/ modify Role.
        }

        private void LogOutBtn_Click(object sender, System.EventArgs e)
        {
            Data.UserData.IsOnline = false;
            Data.DataBase.User.Update(Data.UserData);
            Data.UserData = null;
            this.Visible = false;
            new Login().Visible = true;
        }

        private void AddProdusToShopBtn_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            //TODO: P.claudiu show add produs panel and add to site! if you Admin. Send Request to Owner for approval!
        }

        private void ShowUsersBtn_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            //TODO: P.claudiu show all users.
        }
    }
}
