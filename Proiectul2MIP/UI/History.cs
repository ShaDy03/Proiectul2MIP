using System;
using System.Linq;
using System.Windows.Forms;

namespace Proiectul2MIP.UI
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Shop().Visible = true;
        }

        private void History_Load(object sender, EventArgs e)
        {
            try
            {
                var histories = Data.DataBase.HistoryOrder.GetAll(ho => ho.UserId == Data.UserData.Id).Result.GroupBy(ho => ho.NumberOrder);
                int i = 1;
                string numberOrder = string.Empty;
                MyHistoryOrder.Items.Clear();
                foreach (var history in histories)
                {
                    if(numberOrder != history.Key)
                    {
                        numberOrder = history.Key;
                        MyHistoryOrder.Items.Add($"{numberOrder}:");
                    }
                    foreach(var hi in history)
                    {
                        MyHistoryOrder.Items.Add($"{i} {hi.ProdusName} {hi.Price} {hi.Quantity} {hi.Price * hi.Quantity};");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Connection with database lose!");
            }
        }
    }
}
