using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolistappp
{
    public class TaskFunctions
    {
        private readonly List<Task> _tasks;
        public TaskFunctions()
        {
            _tasks = new List<Task>();

        }

        public void AddTask(string name)
        {
            AddTask(new Task { Name = name });
        }

        public void AddTask(params Task[] tasks) 
        {
            var currentId = 0;
            if (_tasks.Any())
            {
                var selectedLastTask = _tasks.OrderByDescending(x => x.Id).FirstOrDefault();
                currentId = selectedLastTask.Id;
            }

            tasks.ToList().ForEach(x =>
            {
                currentId++;
                x.Id = currentId;
            });

            _tasks.AddRange(tasks);

        }

        public IQueryable<Task> AllTasks()
        {
            return _tasks.AsQueryable();
        }



        public string AllTasksString()
        {
            return string.Join(Environment.NewLine, _tasks.Select(x => x.ToString()));
        }




        











    }



}
