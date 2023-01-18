using Models;
using System.Text;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiectul2MIP.UI
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void ShowPwCBox_CheckedChanged(object sender, System.EventArgs e)
        {
            PwBox.PasswordChar = PwBox.PasswordChar == '*'?'\0':'*';
            CfPWBox.PasswordChar = CfPWBox.PasswordChar == '*' ? '\0' : '*';
        }

        private bool Exists(string userName) => Data.DataBase.User.Exists(name => name.UserName == userName);

        private Task Add(User user)
        {
            user.RoleId = 1;
            user.IsDeleted = false;
            user.IsOnline = false;
            Data.DataBase.User.Add(user);
            return Task.CompletedTask;
        }

        private string EncoderPassword(string password)
        {
            var asciiEncoder = ASCIIEncoding.ASCII.GetBytes(password);
            var encoderResult = Convert.ToBase64String(asciiEncoder);
            return encoderResult;
        }

        private bool IsEqual(string first, string second) => first.Equals(second);

        private async void button1_Click(object sender, System.EventArgs e)
        {
            if (Exists(UserNameBox.Text))
            {
                MessageBox.Show($"This username, {UserNameBox.Text}, already exists!");
                return;
            }

            if (!IsEqual(PwBox.Text, CfPWBox.Text))
            {
                MessageBox.Show("The passwords aren't the same!");
                return;
            }

            await Add(new User()
            {
                UserName = UserNameBox.Text,
                Password = EncoderPassword(PwBox.Text)
            });

            this.Visible = false;
            new Login().Visible = true;
        }
    }
}
