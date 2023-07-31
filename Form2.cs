using Auth.Entities;
using Auth.Services;

namespace Auth
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_reg_login_Click(object sender, EventArgs e)
        {
            var users = MemoryService.Users;

            string username, password;

            if (users != null)
            {
                foreach (var user in users)
                {
                    if (user.UserName == textBox1_login.Text)
                    {
                        MessageBox.Show("Login uje exists");
                        return;
                    }
                }

                if (textBox1_login.Text.Length != 0 && textBox2_password.Text.Length != 0)
                {
                    username = textBox1_login.Text;
                    password = textBox2_password.Text;

                    var user = new User()
                    {
                        Id = Guid.NewGuid(),
                        UserName = username,
                        Password = password,
                    };

                    users.Add(user);

                    MessageBox.Show("Registreded", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Login va parol kiriting!");
                }
            }
        }
    }
}
