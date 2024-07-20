using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_Tracker_Project
{
    internal class Program
    {
        static string[] TaskList = new string[100];
        static int TaskIndex = 0;
        static void Main(string[] args)
        {
            /*
            1- welcom to user
            2- add task
            3- remove task
            4- see all tasks
            5- mark task 
            6- exit
             */

            Console.WriteLine("Welcome in my Task Tracker");
            Console.WriteLine("--------------------------");
            bool cheake = true;

                while(cheake) {
                Console.WriteLine("choose one from this list");
                Console.WriteLine("1- Add task");
                Console.WriteLine("2- Mark task ");
                Console.WriteLine("3- Remove task");
                Console.WriteLine("4- View all tasks");
                Console.WriteLine("5- exit");
                try
                {
                    int chosen = Convert.ToInt32(Console.ReadLine());

                    if (chosen == 1)
                    {
                        AddTask();
                    }
                    else if (chosen == 2)
                    {
                        MarkTask();
                    }
                    else if (chosen == 3)
                    {
                        RemoveTask();
                    }
                    else if (chosen == 4)
                    {
                        ViewAllTasks();
                    }
                    else if (chosen == 5)
                    {
                        Console.WriteLine("Good Bye");

                        Environment.Exit(0);


                    }
                    else
                    {
                        Console.WriteLine("You should choose from this list . ");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

        }


        }

        public static void AddTask()
        {
            Console.WriteLine("Enter Your Added Task Name : ");
            string TaskName = Console.ReadLine();
            TaskList[TaskIndex]= TaskName;
            Console.WriteLine("Successfully Added Task");
            Console.WriteLine("--------------------------");
            TaskIndex++;
        }



        public static void MarkTask()
        {
            Console.WriteLine("Enter Task number : ");
            int TaskNumber = Convert.ToInt32(Console.ReadLine())-1;
            TaskList[TaskNumber] = TaskList[TaskNumber] + "  ( This Task Completed. )";
            Console.WriteLine("Successfully Marked Task");
            Console.WriteLine("--------------------------");
        }


             //this way is not the best way to remove task
             //you should use shift or another data structure
        public static void RemoveTask()
        {
            Console.WriteLine("Enter Task number to remove it : ");
            int TaskNumber = Convert.ToInt32(Console.ReadLine())-1;
            TaskList[TaskNumber] = string.Empty;
            Console.WriteLine("Successfully Removed Task");
            Console.WriteLine("--------------------------");
            

        }



        public static void ViewAllTasks()
        {
            Console.WriteLine("Your Tasks are : ");
            for (int i = 0; i < TaskIndex; i++)
            {
                Console.WriteLine(i+1+". "+ TaskList[i] );
            }
            Console.WriteLine("--------------------------");
        }
    }
}
