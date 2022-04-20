using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopLibrary
{
    public class Application
    {
        /// <summary>
        /// 
        /// </summary>
        private Application Applications;
        private List<TaskList> TaskLists;
       /// <summary>
       /// 
       /// </summary>
       /// <param name="application"></param>
       /// <param name="taskLists"></param>
        public Application(Application application, List<TaskList> taskLists)
        {
            this.Applications = application;
            this.TaskLists = taskLists;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Application GetApplication()
        {
            return this.Applications;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="taskList"></param>
        public void CreateTaskList(string name, List<Task> taskList)
        {
            TaskLists.Add(new TaskList(name, taskList));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public TaskList GetTaskListNames(string name)
        {
            return TaskLists.LastOrDefault(item => item.GetName() == name);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByToday()
        {
            foreach (TaskList taskList in TaskLists)
            {
                return taskList.GetTasksByToday();
            }
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Task> GetTasksByFuture()
        {
            foreach (TaskList taskList in TaskLists)
            {
                return taskList.GetTasksByFuture();
            }
            return null;
        }
    }
}



