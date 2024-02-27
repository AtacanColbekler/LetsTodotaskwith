using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace Todolistappp
{
    public class TaskFunctions
    {
        Data db = new Data();

        private readonly List<Task> _tasks;
        public TaskFunctions()
        {
            _tasks = new List<Task>();
            _tasks = db.GetDatabase();

        }

        public void AddTask(string name, DateTime duedate)
        {
            AddTask(new Task { Name = name, DueDate = duedate });
        }

        public Task FindById(int id)
        {
            return _tasks.FirstOrDefault(x => x.Id == id);
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

        public void UpdateTask(Task outertask)
        {
            var Tasks = _tasks.Where(Task => Task.Name.ToLower().Contains("a")).ToList(); 
            Tasks.ForEach(Task => {
            
            
            
            
            });

            var selectedTask = _tasks.FirstOrDefault(x => x.Id == outertask.Id);
            if (selectedTask == null)
            {
                throw new Exception(string.Format("Cannot find the Task with Id of {0}", outertask.Id));
            }
            else
            {
                _tasks.Remove(selectedTask);
                var newtask = outertask;
                _tasks.Add(newtask);
                
            }
            
            
            
            


        }

        public void Delete(int id)
        {
            var selectedTask = FindById(id);
            if (selectedTask == null)
            {
                throw new Exception(string.Format("Cannot find the Task with Id of {0}", id));
            }

                _tasks.Remove(selectedTask);
        }

        public IQueryable<Task> AllTasks()
        {
            return _tasks.AsQueryable();
        }



        public string AllTasksString()
        {
            return string.Join(Environment.NewLine, _tasks.Select(x => x.ToString()));
        }

        public IQueryable<Task> DueDates(DateTime now)
        {
            return _tasks.Where(x => x.DueDate < now).AsQueryable();
        }





    }



}
