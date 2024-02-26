using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;

namespace Todolistappp
{
    public partial class Form1 : MaterialForm
    {
        TaskFunctions TaskList = new TaskFunctions();
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple800, Primary.DeepPurple900, Primary.DeepPurple500, Accent.LightBlue200, TextShade.WHITE);

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {
            var taskname = materialTextBox1.Text.ToString();
            var duedate = dateTimePicker1.Value;
            var duetime = dateTimePicker2.Value;

            DateTime taskdue = new DateTime();

            taskdue = duedate.Date + duetime.TimeOfDay;





            TaskList.AddTask(taskname, taskdue);
            UpdateListBox();
            

        }

        public void UpdateListBox()
        {


            materialListBox1.Clear();
            

            var list = TaskList.AllTasks().ToList();

            foreach (var item in list)
            {
                materialListBox1.AddItem(item.Id + "." + item.Name + " " + item.DueDate);
                
            }



        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {

        }

        private void materialFloatingActionButton2_Click(object sender, EventArgs e)
        {
            if (materialListBox1.SelectedItem != null)
            {
                string item = materialListBox1.SelectedItem.Text;
                string[] subStrings = item.Split('.');
                int id = Convert.ToInt32(subStrings[0]);

                TaskList.Delete(id);
                UpdateListBox();
            }


        }



        public void BackAnim()
        {
            var stopPosX = 0;

            while (panel1.Location.X != stopPosX)
            {
                panel1.Location = new Point(panel1.Location.X - 3, 63);
            }

            


        }

        public void returnAnim()
        {
            var stopPosX = 417;

            while (panel1.Location.X != stopPosX)
            {
                panel1.Location = new Point(panel1.Location.X + 3, 63);
            }
            
        }

        private void materialListBox1_DoubleClick(object sender, EventArgs e)
        {


            if (materialListBox1.SelectedItem != null)
            {
                
                string item = materialListBox1.SelectedItem.Text;
                string[] subStrings = item.Split('.');
                var id = Convert.ToInt32(subStrings[0]);

                var selectedTask = TaskList.FindById(id);





                EditLabel1.Text = selectedTask.Id.ToString();
                EditText1.Text = selectedTask.Name.ToString();
                EditDateTimePicker1.Value = selectedTask.DueDate.Date;
                EditDateTimePicker2.Text = selectedTask.DueDate.TimeOfDay.ToString();
                TimeSpan ts = selectedTask.DueDate - DateTime.Now;
                EditLabel2.Text = ts.Days + " Days  " + ts.Hours + " Hours " + ts.Minutes + " Minutes left!";

                BackAnim();


            }
            else
            {
                MessageBox.Show("Nothing selected");
            }



        }

        private void materialFloatingActionButton3_Click(object sender, EventArgs e)
        {
            returnAnim();
        }

        private void EditButton1_Click(object sender, EventArgs e)
        {
            //Change the task button
            if (materialListBox1.SelectedItem != null)
            {
                
                var id = Convert.ToInt32(EditLabel1.Text);
                var name = Convert.ToString(EditText1.Text);
                DateTime date = Convert.ToDateTime(EditDateTimePicker1.Value);
                DateTime time = Convert.ToDateTime(EditDateTimePicker2.Value);

                var duedate = date.Date + time.TimeOfDay;




                var foundTask = TaskList.FindById(id);
                if (foundTask != null)
                {
                    foundTask.Id = id;
                    foundTask.Name = name;
                    foundTask.DueDate = duedate;
                    TaskList.UpdateTask(foundTask);
                    MessageBox.Show("task changed");

                }
                else
                {
                    MessageBox.Show("Could not find the task");
                }


                

            }
            UpdateListBox();
            returnAnim();
        }

        
    }
}