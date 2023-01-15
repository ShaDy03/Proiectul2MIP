using Models;
using System.Collections.Generic;
using System.Reflection;

namespace Proiectul2MIP
{
    public class MyCart
    {
        public static MyCart Instance = new MyCart();
        private MyCart()
        { }
        public List<Produs> MyShopCart = new List<Produs>();

        public void Remove(int index)
        {
            MyShopCart.Remove(MyShopCart[index]);
        }
    }
}
