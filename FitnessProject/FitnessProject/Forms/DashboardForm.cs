using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessProject.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            pictureBox_Logo.Image = Image.FromFile("../../../Images/logo.png");
            button_close.Image = Image.FromFile("../../../Images/x-mark.png");

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DashboardForm_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;

            //show the login form
            LoginForm lgn = new LoginForm(this);
            lgn.Show();
        }

        private void button_workouttype_Click(object sender, EventArgs e)
        {
            //show the workout types form
            WorkoutTypesForm wtF = new WorkoutTypesForm();
            wtF.Show();
        }
    }
}
