using MaterialSkin;
using MaterialSkin.Controls;
using System.Text.RegularExpressions;

namespace Todolistappp
{
    public partial class Form1 : MaterialForm
    {
        TaskFunctions book = new TaskFunctions();
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

            book.AddTask(taskname);
            UpdateListBox();

        }

        public void UpdateListBox()
        {


            materialListBox1.Clear();
            foreach (var s in Regex.Split(book.AllTasksString(), "\n"))
            {
                if (s != "")
                {
                    materialListBox1.AddItem(s);

                }
            }




        }
    }
}