namespace Lecture8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb2_password.PasswordChar = '*';
        }

        private void bt1_login_Click(object sender, EventArgs e)
        {
            string username = tb1_username.Text;
            string password = tb2_password.Text;

            // Check username and password
            if (username == "admin" && password == "123456")
            {
                // Open Form2 if login successful
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}
