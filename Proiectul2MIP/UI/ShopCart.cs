using Models;
using System;
using System.Windows.Forms;

namespace Proiectul2MIP.UI
{
    public partial class ShopCart : Form
    {
        public ShopCart()
        {
            InitializeComponent();
        }

        private void ShopCart_Load(object sender, EventArgs e)
        {
            ActualiserShopCart();
        }

        private void ActualiserShopCart()
        {
            CartBox.Items.Clear();
            double total = 0;
            foreach(var produs in MyCartO.MyShopCart)
            {
                total += produs.Quantity * produs.Price;
                CartBox.Items.Add($"{produs.ProdusName}, {produs.Price}, {produs.Quantity}, total:{produs.Quantity * produs.Price}");
            }
            TotalLBL.Text = $"Total: {total} lei";
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Shop().Visible = true;
        }

        private void DeleteProdus_Click(object sender, EventArgs e)
        {
            try
            {
                var index = Int32.Parse(IndexBox.Text);
                if (index >= MyCartO.MyShopCart.Count)
                    throw new ArgumentException("Index is out of range");

                MyCartO.Remove(index);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ActualiserShopCart();
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            string numberOrder = Guid.NewGuid().ToString();
            foreach(var produs in MyCartO.MyShopCart)
            {
                Data.DataBase.HistoryOrder.Add(new HistoryOrder()
                {
                    NumberOrder = numberOrder,
                    ProdusName = produs.ProdusName,
                    Price = produs.Price,
                    Quantity = produs.Quantity,
                    UserId = Data.UserData.Id,
                    Total = produs.Price * produs.Quantity
                });
            }
        }
    }
}
