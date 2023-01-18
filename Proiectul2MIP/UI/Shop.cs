using Models;
using System.Threading.Tasks;
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
            new ShopCart().Visible = true;
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
            new OnlineUser().Visible = true;
        }

        private void MyProfileBtn_Click(object sender, System.EventArgs e)
        {
            Data.OtherUser = Data.UserData;
            this.Visible = false;
            new Profile().Visible = true;
        }

        private void LogOutBtn_ClickAsync(object sender, System.EventArgs e)
        {
            Data.UserData.IsOnline = false;
            Data.DataBase.User.Update(Data.UserData).Wait();
            Data.UserData = null;
            this.Visible = false;
            new Login().Visible = true;
        }

        private void AddProdusToShopBtn_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            new AddProdus().Visible = true;
        }

        private void ShowUsersBtn_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            var users = Data.DataBase.User.GetAll().Result;

        }
    }
}
