
namespace ConsoleTaskManager
{
    internal class TaskOption
    {
        private static string fileName;
        private static string processName;

        public static void TaskOptions()
        {
            Console.Write("\n\t Select Your desired Task Operations\n\t ====================================\n\n\t 1. View list of all Running Processes\n\t 2. To Create a Custom Process\n\t 3. Search for a Process\n\t 4. Create a Custom Thread\n\t 5. Check Thread State\n\n\t ");

            var operationOption = Console.ReadLine();

            switch (operationOption)
            {
                case "1":
                    {
                        TaskOperations.ListProcesses();
                        Utility.ContinueOption();
                    }
                    break;

                case "2":
                    {
                        Console.WriteLine("\n\t Enter a file Name: \n\t ");
                        fileName = Console.ReadLine();
                        TaskOperations.CreateProcess(fileName);
                        Utility.ContinueOption();
                    }
                    break;

                case "3":
                    {
                        Console.Write("\n\t Enter a Process Name: \n\t ");
                        processName = Console.ReadLine();
                        TaskOperations.ManageProcess(processName);
                    }
                    break;

                case "4":
                    {
                        Console.WriteLine("\n\t Enter a Thread Name: \n\t ");
                        var threadName = Console.ReadLine();

                        TaskOperations.CreateThread(threadName);
                        Utility.ContinueOption();
                    }
                    break;

                case "5":
                    {
                        TaskOperations.ViewThreadList();
                        Console.Write("\n\t Enter thread id to check it's status\n\n\t ");
                        var threadStateId = Console.ReadLine();
                        
                        TaskOperations.CheckThreadState(threadStateId);
                        Utility.ContinueOption();
                    }
                    break;

                default:
                    {
                        Console.WriteLine("\n\t You entered an invalid option, try again: \n");
                        TaskOptions();
                    }
                    break;
            }
        }
    }
}
