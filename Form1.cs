using MaterialSkin;
using MaterialSkin.Controls;
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
        {
            var now = DateTime.Now;
            var duedates = TaskList.DueDates(now).ToList();

            foreach (var item in duedates)
            {
                var taskname = item.Name;
                TimeSpan ts = item.DueDate - now;
                MessageBox.Show("Due date in " +ts.Days+" Days, "+ ts.Hours +" hours, "+ ts.Minutes + " minutes");
            }
            


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
            reminder();

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





    }
}