using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopLibrary
{
    public class TaskList
    {
        /// <summary>
        /// 
        /// </summary>
        private string Name;
        private List<Task> Tasks;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tasks"></param>
        public TaskList(string name, List<Task> tasks)
        {
            this.Name = name;
            this.Tasks = tasks;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return Name;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="task"></param>
        public void AddTask(Task task)
        {
            this.Tasks.Add(task);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasks()
        {
            return Tasks;
        }

        public void Remove(Task task)
        {
            this.Tasks.Remove(task);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByToday()
        {
            DateTime date = DateTime.Now;
            return (List<Task>)this.Tasks.Where(item => item.Due == date);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByFuture()
        {
            DateTime date = DateTime.Now;
            return (List<Task>)this.Tasks.Where(item => item.Due > date);
        }

    }
}
