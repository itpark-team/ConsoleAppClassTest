using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TasksManager tasksManager = new TasksManager();
            int action;

            TaskItem taskItem1 = new TaskItem("21.11.2021", "25.11.2021", "Закодить класс", "класс должен делать это это это...", TaskItem.ImportaceGrade.NotImportant);

            TaskItem taskItem2 = new TaskItem("26.11.2021", "27.11.2021", "Ревью класса", "сделать автотесты", TaskItem.ImportaceGrade.Important);

            tasksManager.AddTaskItem(taskItem1);
            tasksManager.AddTaskItem(taskItem2);

            while (true)
            {
                Console.Clear();
                tasksManager.PrintTaskItems();

                Console.WriteLine("Меню.");
                Console.WriteLine("1.Добавить задачу");
                Console.WriteLine("2.Посчитать продолжительность задачи");
                Console.WriteLine("0.Выход");

                Console.Write("Введите действие: ");
                action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        {
                            Console.Write("Введите начальную дату работ: ");
                            string startDateTime = Console.ReadLine();

                            Console.Write("Введите конечную дату работ: ");
                            string finishDateTime = Console.ReadLine();

                            Console.Write("Введите заголовок: ");
                            string title = Console.ReadLine();

                            Console.Write("Введите описание: ");
                            string description = Console.ReadLine();

                            Console.Write("Введите важность(0,1,2): ");
                            TaskItem.ImportaceGrade importaceGrade = (TaskItem.ImportaceGrade)int.Parse(Console.ReadLine());

                            TaskItem taskItem = new TaskItem(startDateTime, finishDateTime, title, description, importaceGrade);

                            tasksManager.AddTaskItem(taskItem);

                        }
                        break;

                    case 2:
                        {
                            try
                            {
                                Console.Write("Введите индекс задачи для вычисления: ");
                                int index = int.Parse(Console.ReadLine());

                                Console.WriteLine($"продолжительность(дни) = {tasksManager.CaclulateTaskDuration(index)}");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }

                        }
                        break;

                    case 0:
                        {
                            Environment.Exit(0);
                        }
                        break;

                    default:
                        Console.WriteLine("Такой команды не существует");
                        break;

                }
                Console.ReadKey();

            }


        }
    }
}
