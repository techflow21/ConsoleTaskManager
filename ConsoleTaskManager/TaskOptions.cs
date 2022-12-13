
namespace ConsoleTaskManager
{
    internal class TaskOption
    {
        private static string fileName;
        private static string processName;
        private static ThreadStart threadStart;
        private static string threadOption;

        public static void TaskOptions()
        {
            Console.WriteLine("\n\t Select Your desired Task Operations\n\t ====================================\n\n\t 1. View list of all Running Processes\n\t 2. To Create a Custom Process\n\t 3. Search for a Process\n\t 4. Create a Custom Thread\n\t 5. Check Thread State\n");

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
                        Console.WriteLine("\n\t Enter a file Name: ");
                        fileName = Console.ReadLine();
                        //fileName = "notepad.exe";
                        TaskOperations.CreateProcess(fileName);
                        Utility.ContinueOption();
                    }
                    break;

                case "3":
                    {
                        Console.WriteLine("\n\t Enter a Process Name: ");
                        processName = Console.ReadLine();

                        TaskOperations.ManageProcess(processName);
                        //Utility.ContinueOption();
                    }
                    break;

                case "4":
                    {
                        Console.WriteLine("\n\t Enter a Thread Name: ");
                        //threadStart = Console.ReadLine();

                        TaskOperations.CreateThread(threadStart);
                        Utility.ContinueOption();
                    }
                    break;

                case "5":
                    {

                        TaskOperations.CheckThreadState(threadOption);
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
