using Models;
using Proiectul2MIP.UI;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiectul2MIP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string EncoderPassword(string password)
        {
            var asciiEncoder = ASCIIEncoding.ASCII.GetBytes(password);
            var encoderResult = Convert.ToBase64String(asciiEncoder);
            return encoderResult;
        }

        private async Task<User> IsCorrectUserAsync(User user)
        {
            if(user == null)
                throw new ArgumentNullException("User is null!");

            if (string.IsNullOrEmpty(user.UserName))
                throw new ArgumentNullException("Username is null!");

            if (string.IsNullOrEmpty(user.Password))
                throw new ArgumentNullException("Password is null!");

            var passwordEncodded = EncoderPassword(user.Password);

            var userDb = await Data.DataBase.User.GetFirstOrDefault(u => u.UserName == user.UserName && u.Password == passwordEncodded);
            userDb.Role = await Data.DataBase.Role.GetById(userDb.RoleId);

            if (userDb == null)
                throw new ArgumentException("This user not exists or password incorrect!");

            return userDb;
        }

        private void LoginBtn_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                Data.UserData = IsCorrectUserAsync(new User()
                {
                    UserName = UserNameBox.Text,
                    Password = PWBox.Text
                }).Result;
                Data.UserData.IsOnline = true;
                Data.DataBase.User.Update(Data.UserData).Wait();

                this.Visible = false;
                new Shop().Visible = true;
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
            
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Register().Visible = true;
        }
    }
}
