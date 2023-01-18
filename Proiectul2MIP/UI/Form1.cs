using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiectul2MIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataBase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var login = new Login();
            this.Visible = false;
            login.Visible = true;
        }

        private string EncoderPassword(string password)
        {
            var asciiEncoder = ASCIIEncoding.ASCII.GetBytes(password);
            var encoderResult = Convert.ToBase64String(asciiEncoder);
            return encoderResult;
        }

        private void DataBase()
        {
            List<Role> roles = new List<Role>()
            {
                new Role(RoleEnum.User.ToString()),
                new Role(RoleEnum.Administrator.ToString()),
                new Role( RoleEnum.Owner.ToString()),
                new Role(RoleEnum.Blocked.ToString())
            };

            List<User> users = new List<User>()
            {
                new User()
                {
                    UserName = "ShaDy",
                    Password = EncoderPassword("admin"),
                    IsDeleted = false,
                    IsOnline = false,
                    RoleId = 3
                },
                new User()
                {
                    UserName = "clau",
                    Password = EncoderPassword("12345"),
                    IsDeleted = false,
                    IsOnline = false,
                    RoleId = 1
                }
            };

            List<Produs> produs = new List<Produs>()
            {
                new Produs()
                {
                    ProdusName = "Paine",
                    Quantity = 20,
                    Price = 3.16,
                    Exist = true
                },
                new Produs()
                {
                    ProdusName = "Apa minerala",
                    Quantity = 30,
                    Price = 1.45,
                    Exist = true
                },
                new Produs()
                {
                    ProdusName = "Cipsuri",
                    Quantity = 44,
                    Price = 4.05,
                    Exist = true
                }
            };



            List<HistoryOrder> historyOrders = new List<HistoryOrder>()
            {
                new HistoryOrder()
                {
                    NumberOrder = Guid.NewGuid().ToString(),
                    ProdusName = "Paine",
                    Quantity = 2,
                    Price = 3.16,
                    Total = 2 * 3.16,
                    UserId = 2
                },
                new HistoryOrder()
                {
                    NumberOrder = Guid.NewGuid().ToString(),
                    ProdusName = "Cipsuri",
                    Quantity = 2,
                    Price = 4.05,
                    Total = 2 * 4.05,
                    UserId = 1
                }
            };

            try
            {
                foreach (var role in roles)
                {
                    if (!Data.DataBase.Role.Exists(r => r.Name == role.Name))
                        Data.DataBase.Role.Add(role);
                }

                foreach (var prod in produs)
                {
                    if (!Data.DataBase.Produs.Exists(pr => pr.ProdusName == prod.ProdusName))
                        Data.DataBase.Produs.Add(prod);
                }

                foreach (User user in users)
                {
                    if (!Data.DataBase.User.Exists(u => u.UserName == user.UserName))
                        Data.DataBase.User.Add(user);
                }

                foreach (var ho in historyOrders)
                {
                    if (!Data.DataBase.HistoryOrder.Exists(hi => hi.ProdusName == ho.ProdusName))
                        Data.DataBase.HistoryOrder.Add(ho);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in connection with database!");
            }
        }
    }
}
