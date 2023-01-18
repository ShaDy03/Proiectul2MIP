using Models;
using System.Collections.Generic;

namespace Proiectul2MIP
{
    public class MyCart
    {
        public static MyCart Instance = new MyCart();
        private MyCart()
        { }
        public List<Produs> MyShopCart = new List<Produs>();
        public List<Produs> ShopProdus = new List<Produs>();

        public void Remove(int index)
        {
            MyShopCart.Remove(MyShopCart[index]);
        }

        public void Add (Produs produs)
        {
            MyShopCart.Add(produs);
            Eliminate(produs);
        }

        private async void Eliminate(Produs produs)
        {
            foreach(var shopprodus in ShopProdus)
            {
                if(shopprodus.ProdusName == produs.ProdusName)
                    shopprodus.Quantity -= produs.Quantity;

                if(shopprodus.Quantity == 0)
                {
                    ShopProdus.Remove(shopprodus);
                    shopprodus.Exist = false;
                    await Common.Instance.DataBase.Produs.Update(shopprodus);
                }
            }
        }
    }
}
