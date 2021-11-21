using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassTest
{
    class TasksManager
    {
        private List<TaskItem> taskItems;

        public TasksManager()
        {
            taskItems = new List<TaskItem>();
        }

        public void AddTaskItem(TaskItem taskItem)
        {
            taskItems.Add(taskItem);
        }

        public void ReplaceTaskItem(int index, TaskItem taskItem)
        {
            if (index >= 0 && index <= taskItems.Count - 1)
            {
                taskItems[index] = taskItem;
            }
            else
            {
                throw new Exception("Задачи с данным номером не найдено");
            }

        }

        public void DeleteTaskItem(int index)
        {
            if (index >= 0 && index <= taskItems.Count - 1)
            {
                taskItems.RemoveAt(index);
            }
            else
            {
                throw new Exception("Задачи с данным номером не найдено");
            }
        }

        public void PrintTaskItems()
        {
            if (taskItems.Count == 0)
            {
                Console.WriteLine("Список задач пуст.");
                Console.WriteLine("--------");

                return;
            }

            for (int i = 0; i < taskItems.Count; i++)
            {
                Console.WriteLine($"Задача №{i}:");
                Console.WriteLine(taskItems[i]);
                Console.WriteLine("--------");
            }
        }

        public int CaclulateTaskDuration(int index)
        {
            if (index >= 0 && index <= taskItems.Count - 1)
            {
                return taskItems[index].CaclulateDuration();
            }
            else
            {
                throw new Exception("Задачи с данным номером не найдено");
            }
        }
    }
}
