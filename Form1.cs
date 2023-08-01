using Auth.Services;

namespace Auth
{
    public partial class Form1 : Form
    {
        int counter = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new();
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            counter++;

            if (counter > 2)
            {
                counter = 1;
            }

            if (counter == 1)
            {
                textBox2.PasswordChar = default(char);
                pictureBox1.Image = Properties.Resources.eye_close;
            }

            if (counter == 2)
            {
                textBox2.PasswordChar = '*';
                pictureBox1.Image = Properties.Resources.eye_open;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var users = MemoryService.Users;

            string username = textBox1.Text;

            var usercha = users.FirstOrDefault(u => u.UserName == username);

            if (usercha != null)
            {
                if (usercha!.Password != textBox2.Text)
                {
                    MessageBox.Show("Invalid", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
                else
                {
                    //MessageBox.Show("Succesfull", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    Form3 form3 = new Form3();
                    form3.Show();
                }
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var random = new Random();

            var index = random.Next(0, 6);

            switch (index)
            {
                case 0: button2.BackColor = Color.Red; break;
                case 1: button2.BackColor = Color.Black; break;
                case 2: button2.BackColor = Color.Blue; break;
                case 3: button2.BackColor = Color.Yellow; break;
                case 4: button2.BackColor = Color.Green; break;
                case 5: button2.BackColor = Color.White; break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}