using Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proiectul2MIP.UI
{
    public partial class AddProdus : Form
    {
        private bool IsOKNameProdus = false;
        private bool IsOKQuantity = false;
        private bool IsOKPrice = false;

        public AddProdus()
        {
            InitializeComponent();
            AddProdusBtn.Enabled = false;
            AddProdusBtn.BackColor = Color.Coral;
            HomeBTN.BackColor = Color.Chartreuse;
        }

        private void CanBeAdd()
        {
            if(IsOKNameProdus && IsOKQuantity && IsOKPrice)
            {
                AddProdusBtn.Enabled = true;
                AddProdusBtn.BackColor = Color.Chartreuse;
            }
        }

        private void NameProdusBox_TextChanged(object sender, EventArgs e)
        {
            if(NameProdusBox.Text != null && NameProdusBox.Text != string.Empty)
            {
                NameProdusLBL.BackColor = Color.Chartreuse;
                IsOKNameProdus = true;
            }
            else
            {
                NameProdusLBL.BackColor = Color.Coral;
                IsOKNameProdus = false;
            }
            CanBeAdd();
        }

        private void QuantityBox_TextChanged(object sender, EventArgs e)
        {
            if (QuantityBox.Text != null && QuantityBox.Text != string.Empty)
            {
                QuantityLBL.BackColor = Color.Chartreuse;
                IsOKQuantity = true;
            }
            else
            {
                QuantityLBL.BackColor = Color.Coral;
                IsOKQuantity = false;
            }
            CanBeAdd();
        }

        private void PriceBox_TextChanged(object sender, EventArgs e)
        {
            if (PriceBox.Text != null && PriceBox.Text != string.Empty)
            {
                PriceBox.BackColor = Color.Chartreuse;
                IsOKPrice = true;
            }
            else
            {
                PriceBox.BackColor = Color.Coral;
                IsOKPrice = false;
            }
            CanBeAdd();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Shop().Visible = true;
        }

        private void AddProdusBtn_Click(object sender, EventArgs e)
        {
            double price = 0;
            int quantity = 0;
            try
            {
                price =Double.Parse(PriceBox.Text);
                quantity = Int32.Parse(QuantityBox.Text);
                Data.DataBase.Produs.Add(new Produs()
                {
                    ProdusName = NameProdusBox.Text,
                    Quantity = quantity,
                    Price = price,
                    Description = DescriptionBox.Text
                });
            }
            catch(Exception)
            {
                MessageBox.Show("Please complete correct all imput");
            }
        }
    }
}
