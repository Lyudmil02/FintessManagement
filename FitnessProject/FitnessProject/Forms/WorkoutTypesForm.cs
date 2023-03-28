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
    public partial class WorkoutTypesForm : Form
    {
        Classes.WorkoutTtypes wrT = new Classes.WorkoutTtypes();

        public WorkoutTypesForm()
        {
            InitializeComponent();
        }

        private void label_close_MouseClick(object sender, MouseEventArgs e)
        {
            label_close.ForeColor = Color.Black;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.LightGray;
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Black;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorkoutTypesForm_Load(object sender, EventArgs e)
        {
            button_add.Image = Image.FromFile("../../../Images/plus.png");
            button_remove.Image = Image.FromFile("../../../Images/trash.png");
            button_edit.Image = Image.FromFile("../../../Images/updates.png");

            dataGridView1.DataSource = wrT.WorkoutTypesList();

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 13, FontStyle.Bold);

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

            dataGridView1.EnableHeadersVisualStyles = false;
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string workoutName = textBox_WrT.Text;
            string number = textBox_NumEx.Text;
            string description = textBox_desc.Text;

            if (workoutName.Trim().Equals(""))
            {
                MessageBox.Show("Enter the workout type", "Empty workout type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (number.Trim().Equals(""))
            {
                MessageBox.Show("Enter the number of exercises", "Empty number exercises", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (description.Trim().Equals(""))
            {
                MessageBox.Show("Enter the description", "Empty description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (wrT.AddWorkout(workoutName, number, description))
                {
                    MessageBox.Show("New workout type added successfully", "New workout type", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataGridView1.DataSource = wrT.WorkoutTypesList();
                }
                else
                {
                    MessageBox.Show("Workout type not added", "Add-error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);

                if (wrT.RemoveWorkout(id))
                {
                    MessageBox.Show("Workout type removed successfully", "Workout type removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox_id.Text = "";
                    textBox_WrT.Text = "";
                    textBox_NumEx.Text = "";
                    textBox_desc.Text = "";

                    dataGridView1.DataSource = wrT.WorkoutTypesList();
                }
                else
                {
                    MessageBox.Show("Workout type not removed", "Removed-error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string workoutName = textBox_WrT.Text;
                string number = textBox_NumEx.Text;
                string description = textBox_desc.Text;

                if (workoutName.Trim().Equals(""))
                {
                    MessageBox.Show("Enter the workout type", "Empty workout type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (number.Trim().Equals(""))
                {
                    MessageBox.Show("Enter the number of exercises", "Empty number exercises", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (description.Trim().Equals(""))
                {
                    MessageBox.Show("Enter the description", "Empty description", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (wrT.EditWorkout(id, workoutName, number, description))
                    {
                        MessageBox.Show("Workout type updated successfully", "Workout type update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView1.DataSource = wrT.WorkoutTypesList();
                    }
                    else
                    {
                        MessageBox.Show("Workout type not updated", "Edit-error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_WrT.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_NumEx.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_desc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
