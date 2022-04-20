
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class TaskList
    {
        private string name { get; set; }
        private List<Task> tasks { get; set; }

        public TaskList(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// возвращает имя списка задач
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// добавляет задачу в список задач
        /// </summary>
        /// <param name="task"></param>
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }
        /// <summary>
        /// возвращает список всех задач
        /// </summary>
        /// <returns></returns>
        public List <Task> GetTasks()
        {
            return tasks;
        }
        /// <summary>
        /// удаляет задачу из списка задач
        /// </summary>
        /// <param name="task"></param>
        public void Remove(Task task)
        {
            if (tasks.Contains(task))
            {
                tasks.Remove(task);
            }
        }
    }
}
