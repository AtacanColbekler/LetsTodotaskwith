namespace Todolistappp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialFloatingActionButton1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialFloatingActionButton2 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // materialFloatingActionButton1
            // 
            materialFloatingActionButton1.Depth = 0;
            materialFloatingActionButton1.Icon = Properties.Resources.round_add_black_24dp;
            materialFloatingActionButton1.Location = new Point(325, 713);
            materialFloatingActionButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton1.Name = "materialFloatingActionButton1";
            materialFloatingActionButton1.Size = new Size(70, 70);
            materialFloatingActionButton1.TabIndex = 2;
            materialFloatingActionButton1.TextAlign = ContentAlignment.TopLeft;
            materialFloatingActionButton1.UseVisualStyleBackColor = true;
            materialFloatingActionButton1.Click += materialFloatingActionButton1_Click;
            // 
            // materialListBox1
            // 
            materialListBox1.BackColor = Color.White;
            materialListBox1.BorderColor = Color.LightGray;
            materialListBox1.Depth = 0;
            materialListBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBox1.Location = new Point(0, 63);
            materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBox1.Name = "materialListBox1";
            materialListBox1.SelectedIndex = -1;
            materialListBox1.SelectedItem = null;
            materialListBox1.Size = new Size(414, 834);
            materialListBox1.TabIndex = 3;
            materialListBox1.SelectedIndexChanged += materialListBox1_SelectedIndexChanged;
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Microsoft Sans Serif", 9.6F, FontStyle.Regular, GraphicsUnit.Point);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(30, 733);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(249, 50);
            materialTextBox1.TabIndex = 4;
            materialTextBox1.Text = "Task Name";
            materialTextBox1.TrailingIcon = null;
            // 
            // materialFloatingActionButton2
            // 
            materialFloatingActionButton2.Depth = 0;
            materialFloatingActionButton2.Icon = Properties.Resources.round_remove_black_24dp;
            materialFloatingActionButton2.Location = new Point(325, 804);
            materialFloatingActionButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialFloatingActionButton2.Name = "materialFloatingActionButton2";
            materialFloatingActionButton2.Size = new Size(70, 70);
            materialFloatingActionButton2.TabIndex = 5;
            materialFloatingActionButton2.Text = "materialFloatingActionButton2";
            materialFloatingActionButton2.UseVisualStyleBackColor = true;
            materialFloatingActionButton2.Click += materialFloatingActionButton2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(29, 824);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(112, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(147, 824);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(132, 27);
            dateTimePicker2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 896);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(materialFloatingActionButton2);
            Controls.Add(materialTextBox1);
            Controls.Add(materialFloatingActionButton1);
            Controls.Add(materialListBox1);
            MaximizeBox = false;
            Name = "Form1";
            Sizable = false;
            Text = "TodoList App";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}