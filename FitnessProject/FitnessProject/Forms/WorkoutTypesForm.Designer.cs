
namespace FitnessProject.Forms
{
    partial class WorkoutTypesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.label_desc = new System.Windows.Forms.Label();
            this.textBox_NumEx = new System.Windows.Forms.TextBox();
            this.label_NmEx = new System.Windows.Forms.Label();
            this.labelWrT = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_WrT = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(976, 87);
            this.label1.TabIndex = 1;
            this.label1.Text = "WORKOUT TYPES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_remove);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.textBox_desc);
            this.panel1.Controls.Add(this.label_desc);
            this.panel1.Controls.Add(this.textBox_NumEx);
            this.panel1.Controls.Add(this.label_NmEx);
            this.panel1.Controls.Add(this.labelWrT);
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Controls.Add(this.textBox_WrT);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(5, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 347);
            this.panel1.TabIndex = 2;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.White;
            this.button_edit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_edit.Location = new System.Drawing.Point(284, 273);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(111, 40);
            this.button_edit.TabIndex = 11;
            this.button_edit.Text = "Edit";
            this.button_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.White;
            this.button_remove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_remove.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_remove.Location = new System.Drawing.Point(123, 273);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(147, 40);
            this.button_remove.TabIndex = 10;
            this.button_remove.Text = "Remove";
            this.button_remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.White;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_add.Location = new System.Drawing.Point(15, 273);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(94, 40);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "Add";
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_desc
            // 
            this.textBox_desc.Location = new System.Drawing.Point(170, 184);
            this.textBox_desc.Multiline = true;
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(227, 74);
            this.textBox_desc.TabIndex = 8;
            // 
            // label_desc
            // 
            this.label_desc.AutoSize = true;
            this.label_desc.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_desc.Location = new System.Drawing.Point(13, 184);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(127, 30);
            this.label_desc.TabIndex = 7;
            this.label_desc.Text = "Description:";
            // 
            // textBox_NumEx
            // 
            this.textBox_NumEx.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_NumEx.Location = new System.Drawing.Point(236, 137);
            this.textBox_NumEx.Multiline = true;
            this.textBox_NumEx.Name = "textBox_NumEx";
            this.textBox_NumEx.Size = new System.Drawing.Size(161, 30);
            this.textBox_NumEx.TabIndex = 6;
            // 
            // label_NmEx
            // 
            this.label_NmEx.AutoSize = true;
            this.label_NmEx.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NmEx.Location = new System.Drawing.Point(13, 137);
            this.label_NmEx.Name = "label_NmEx";
            this.label_NmEx.Size = new System.Drawing.Size(217, 30);
            this.label_NmEx.TabIndex = 5;
            this.label_NmEx.Text = "Number of exercises:";
            // 
            // labelWrT
            // 
            this.labelWrT.AutoSize = true;
            this.labelWrT.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWrT.Location = new System.Drawing.Point(13, 83);
            this.labelWrT.Name = "labelWrT";
            this.labelWrT.Size = new System.Drawing.Size(155, 30);
            this.labelWrT.TabIndex = 4;
            this.labelWrT.Text = "Workout Type:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_id.Location = new System.Drawing.Point(13, 34);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(125, 30);
            this.label_id.TabIndex = 3;
            this.label_id.Text = "ID workout:";
            // 
            // textBox_WrT
            // 
            this.textBox_WrT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_WrT.Location = new System.Drawing.Point(170, 83);
            this.textBox_WrT.Multiline = true;
            this.textBox_WrT.Name = "textBox_WrT";
            this.textBox_WrT.Size = new System.Drawing.Size(227, 30);
            this.textBox_WrT.TabIndex = 2;
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_id.Location = new System.Drawing.Point(170, 34);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(227, 30);
            this.textBox_id.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(420, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(527, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Yellow;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Castellar", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_close.ForeColor = System.Drawing.Color.LightGray;
            this.label_close.Location = new System.Drawing.Point(918, 1);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(58, 54);
            this.label_close.TabIndex = 3;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // WorkoutTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkoutTypesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkoutTypesForm";
            this.Load += new System.EventHandler(this.WorkoutTypesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.TextBox textBox_NumEx;
        private System.Windows.Forms.Label label_NmEx;
        private System.Windows.Forms.Label labelWrT;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_WrT;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.Label label_desc;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_remove;
    }
}