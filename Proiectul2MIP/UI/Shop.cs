using Models;
using System;
using System.Drawing;
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

            ProdusListBox.Items.Clear();
            ProdusListBox.Items.Add($"ProdusName |__| Price |__| Quantity");

            int i = 1;

            foreach (var produs in Cart.ShopProdus)
            {
                ProdusListBox.Items.Add($"{i}) {produs.ProdusName}  {produs.Price}  {produs.Quantity}");
                i++;
            }
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

        private void IndexBox_TextChanged(object sender, System.EventArgs e)
        {
            if (IndexBox.Text != string.Empty && IndexBox.Text != null)
                IndexBox.BackColor = Color.Chartreuse;
            else
                IndexBox.BackColor = Color.Coral;
        }

        private void QuantityBox_TextChanged(object sender, System.EventArgs e)
        {
            if (QuantityBox.Text != string.Empty && QuantityBox.Text != null)
                QuantityBox.BackColor = Color.Chartreuse;
            else
                QuantityBox.BackColor = Color.Coral;
        }

        private void AddProdusMyOrder_Click(object sender, System.EventArgs e)
        {
            if(IndexBox.Text != string.Empty && IndexBox.Text != null && QuantityBox.Text != string.Empty && QuantityBox.Text != null)
            {
                var quantity = 0;
                try
                {
                    var produs = Cart.ShopProdus[Int32.Parse(IndexBox.Text) - 1];
                    
                    quantity = Int32.Parse(QuantityBox.Text);
                    if(quantity > produs.Quantity) 
                    {
                        MessageBox.Show("please, insert correct the quantity!");
                        return;
                    }
                    
                    Cart.Add(new Produs()
                    {
                        ProdusName = produs.ProdusName,
                        Quantity = quantity,
                        Price = produs.Price,
                        Description = produs.Description
                    });
                    double total = Double.Parse(TotalLBL.Text);
                    TotalLBL.Text = $"{total + (quantity * produs.Price)}";
                }
                catch
                {
                    MessageBox.Show("Please insert correct value");
                }
            }
        }
    }
}
