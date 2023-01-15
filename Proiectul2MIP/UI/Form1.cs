using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Proiectul2MIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {
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
            foreach (var user in users)
            {
                if (!Data.DataBase.User.Exists(u => u.UserName == user.UserName))
                    Data.DataBase.User.Add(user);
            }
        }
    }
}
