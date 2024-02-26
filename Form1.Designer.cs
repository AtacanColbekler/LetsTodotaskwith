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
            panel1 = new Panel();
            EditLabel2 = new MaterialSkin.Controls.MaterialLabel();
            EditButton1 = new MaterialSkin.Controls.MaterialButton();
            EditLabel1 = new MaterialSkin.Controls.MaterialLabel();
            EditDateTimePicker2 = new DateTimePicker();
            EditDateTimePicker1 = new DateTimePicker();
            EditText1 = new MaterialSkin.Controls.MaterialTextBox();
            ButtonReturn1 = new MaterialSkin.Controls.MaterialFloatingActionButton();
            panel1.SuspendLayout();
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
            materialListBox1.DoubleClick += materialListBox1_DoubleClick;
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
            // panel1
            // 
            panel1.Controls.Add(EditLabel2);
            panel1.Controls.Add(EditButton1);
            panel1.Controls.Add(EditLabel1);
            panel1.Controls.Add(EditDateTimePicker2);
            panel1.Controls.Add(EditDateTimePicker1);
            panel1.Controls.Add(EditText1);
            panel1.Controls.Add(ButtonReturn1);
            panel1.Location = new Point(417, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 834);
            panel1.TabIndex = 8;
            // 
            // EditLabel2
            // 
            EditLabel2.AutoSize = true;
            EditLabel2.Depth = 0;
            EditLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            EditLabel2.Location = new Point(147, 56);
            EditLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            EditLabel2.Name = "EditLabel2";
            EditLabel2.Size = new Size(107, 19);
            EditLabel2.TabIndex = 6;
            EditLabel2.Text = "materialLabel1";
            // 
            // EditButton1
            // 
            EditButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EditButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            EditButton1.Depth = 0;
            EditButton1.HighEmphasis = true;
            EditButton1.Icon = null;
            EditButton1.Location = new Point(214, 752);
            EditButton1.Margin = new Padding(4, 6, 4, 6);
            EditButton1.MouseState = MaterialSkin.MouseState.HOVER;
            EditButton1.Name = "EditButton1";
            EditButton1.NoAccentTextColor = Color.Empty;
            EditButton1.Size = new Size(121, 36);
            EditButton1.TabIndex = 5;
            EditButton1.Text = "Change Task";
            EditButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            EditButton1.UseAccentColor = false;
            EditButton1.UseVisualStyleBackColor = true;
            EditButton1.Click += EditButton1_Click;
            // 
            // EditLabel1
            // 
            EditLabel1.AutoSize = true;
            EditLabel1.Depth = 0;
            EditLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            EditLabel1.Location = new Point(20, 145);
            EditLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            EditLabel1.Name = "EditLabel1";
            EditLabel1.Size = new Size(14, 19);
            EditLabel1.TabIndex = 4;
            EditLabel1.Text = "Id";
            // 
            // EditDateTimePicker2
            // 
            EditDateTimePicker2.Format = DateTimePickerFormat.Time;
            EditDateTimePicker2.Location = new Point(44, 333);
            EditDateTimePicker2.Name = "EditDateTimePicker2";
            EditDateTimePicker2.Size = new Size(109, 27);
            EditDateTimePicker2.TabIndex = 3;
            // 
            // EditDateTimePicker1
            // 
            EditDateTimePicker1.Format = DateTimePickerFormat.Short;
            EditDateTimePicker1.Location = new Point(44, 245);
            EditDateTimePicker1.Name = "EditDateTimePicker1";
            EditDateTimePicker1.Size = new Size(109, 27);
            EditDateTimePicker1.TabIndex = 2;
            // 
            // EditText1
            // 
            EditText1.AnimateReadOnly = false;
            EditText1.BorderStyle = BorderStyle.None;
            EditText1.Depth = 0;
            EditText1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            EditText1.LeadingIcon = null;
            EditText1.Location = new Point(44, 130);
            EditText1.MaxLength = 50;
            EditText1.MouseState = MaterialSkin.MouseState.OUT;
            EditText1.Multiline = false;
            EditText1.Name = "EditText1";
            EditText1.Size = new Size(328, 50);
            EditText1.TabIndex = 1;
            EditText1.Text = "";
            EditText1.TrailingIcon = null;
            // 
            // ButtonReturn1
            // 
            ButtonReturn1.Depth = 0;
            ButtonReturn1.Icon = null;
            ButtonReturn1.Location = new Point(20, 741);
            ButtonReturn1.MouseState = MaterialSkin.MouseState.HOVER;
            ButtonReturn1.Name = "ButtonReturn1";
            ButtonReturn1.Size = new Size(70, 70);
            ButtonReturn1.TabIndex = 0;
            ButtonReturn1.Text = "materialFloatingActionButton3";
            ButtonReturn1.UseVisualStyleBackColor = true;
            ButtonReturn1.Click += materialFloatingActionButton3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 896);
            Controls.Add(panel1);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton1;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialFloatingActionButton materialFloatingActionButton2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialFloatingActionButton ButtonReturn1;
        private MaterialSkin.Controls.MaterialLabel EditLabel1;
        private DateTimePicker EditDateTimePicker2;
        private DateTimePicker EditDateTimePicker1;
        private MaterialSkin.Controls.MaterialTextBox EditText1;
        private MaterialSkin.Controls.MaterialButton EditButton1;
        private MaterialSkin.Controls.MaterialLabel EditLabel2;
    }
}