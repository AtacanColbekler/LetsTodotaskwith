using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics.Eventing.Reader;
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


        public void reminder()
        {//calculate which duedate is passed and create a reminder saying you have outdate tasks
            var now = DateTime.Now;
            var duedates = TaskList.DueDates(now).ToList();

            
            foreach (var item in duedates)
            {
                if (item != null)
                {
                    var taskname = item.Name;
                    TimeSpan ts = item.DueDate - now;
                    MessageBox.Show("Due date in " + ts.Days + " Days, " + ts.Hours + " hours, " + ts.Minutes + " minutes");

                }

                
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reminder();
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
            foreach (var s in Regex.Split(TaskList.AllTasksString(), "\n"))
            {
                if (s != "")
                {
                    materialListBox1.AddItem(s);

                }
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
                string[] subStrings = item.Split(' ');
                int id = Convert.ToInt32(subStrings[0]);

                TaskList.Delete(id);
                UpdateListBox();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
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
                string[] subStrings = item.Split(' ');

                var id = Convert.ToInt32(subStrings[0]);
                var name = Convert.ToString(subStrings[1]);
                DateTime date = Convert.ToDateTime(subStrings[2]);
                DateTime time = Convert.ToDateTime(subStrings[3] + subStrings[4]);
                


                var duedate = date.Date + time.TimeOfDay;

                EditLabel1.Text = id.ToString();
                EditText1.Text = name;
                EditDateTimePicker1.Value = date;
                EditDateTimePicker2.Value = time;
                TimeSpan ts = duedate - DateTime.Now;
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