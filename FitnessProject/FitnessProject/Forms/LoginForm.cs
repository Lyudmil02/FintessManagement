using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FitnessProject.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pictureBox_user.Image = Image.FromFile("../../../Images/user.png");
            pictureBox_pass.Image = Image.FromFile("../../../Images/pass.png");
        }

        private void label_close_MouseClick(object sender, MouseEventArgs e)
        {
            label_close.ForeColor = Color.Black;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.LightGray;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Black;
        }

    
        private DashboardForm dashF = null;

        public LoginForm(DashboardForm SourceForm)
        {
            dashF = SourceForm as DashboardForm;
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Database.MYDB db = new Database.MYDB();

            string username = textBox_username.Text;
            string password = textBox_password.Text;

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM [Users] WHERE [Username] = @usn AND [Password] = @pass", db.getConnection());

            command.Parameters.Add("@usn", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(dataTable);


            //check if this user exists or not
            if (dataTable.Rows.Count > 0)
            {
                dashF.Enabled = true;
                this.Close();
            }
            else
            {
                //check if the username is empty
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your username to login", "Empty uresname", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //check if the username is empty
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your password to login", "Empty password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //if data not exists
                else
                {
                    MessageBox.Show("Wrong username or password", "Wrong user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}
