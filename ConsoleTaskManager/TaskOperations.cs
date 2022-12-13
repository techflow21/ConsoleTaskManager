using System.Diagnostics;
using System.Linq;

namespace ConsoleTaskManager
{
    public class TaskOperations
    {
        private static Thread thread;
        static Process[] processList = Process.GetProcesses();

        //Method that list all the running processes in my system
        public static void ListProcesses()
        {
            //Process[] processList = Process.GetProcesses();

            Console.WriteLine("\n\t List of Running Processes are as follow:\n\t===========================================\n");
            foreach (Process process in processList)
            {
                Console.WriteLine($"\n\t Process ID: {process.Id}\t Process Name: {process.ProcessName}");
            }
        }


        //Method that start a process
        public static void StartProcess(string ProcessName)
        {
            Process.Start(ProcessName);
            Console.WriteLine($"\n\t Process {ProcessName} has been started.");
        }


        //Method that Kill a started process by accepting the name of the process from user
        public static void KillProcess(string ProcessName)
        {
            Process[] processes = Process.GetProcessesByName(ProcessName);

            foreach (Process process in processes)
            {
                process.Kill();
            }
            Console.WriteLine($"Process {ProcessName} has been Killed.");
        }


        //Method that can create a custom process
        public static void CreateProcess(string fileName)
        {
            Process newProcess = new Process();
            newProcess.StartInfo.FileName = fileName;

            Console.WriteLine($"\n\t Successfully created and added {fileName} process!");
        }


        //Method that accepts a process name and display the process with options to kill it or start it
        public static void ManageProcess(string ProcessName)
        {
            Process[] processes = Process.GetProcessesByName(ProcessName);

            foreach (Process process in processes)
            {
                if (process.ProcessName == ProcessName)
                {
                    Console.WriteLine("\n\t Options: \n\t 1. To start the Process \n\t 2. To kill the Process");
                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            StartProcess(ProcessName);
                            Console.WriteLine($"\n\t {ProcessName} Process has been started.");
                            Utility.ContinueOption();
                            break;

                        case "2":
                            KillProcess(ProcessName);
                            Console.WriteLine($"\n\t {ProcessName} Process has been killed.");
                            Utility.ContinueOption();
                            break;

                        default:
                            {
                                Console.WriteLine("\n\t Invalid option entered! try again: ");
                                ManageProcess(ProcessName);
                            }
                            break;
                    }

                    Console.WriteLine($"\n\t Process Name: {process.ProcessName}");

                }
                else
                {
                    Console.WriteLine("\n\t The Process name you entered does not exist!, try again: ");
                    ManageProcess(ProcessName);
                }    
            }
        }


        //Method that allow creation of custom thread
        public static void CreateThread(ThreadStart threadStart)
        {
            Thread thread = new Thread(threadStart);
            thread.Start();
            Console.WriteLine("Custom thread has been created.");
        }


        //Method that check if a thread isAlive
        public static bool CheckThreadAlive(Thread thread)
        {
            return thread.IsAlive;
        }


        //Method that check if a thread is sleeping
        public static bool CheckThreadSleeping(Thread thread)
        {
            return thread.ThreadState == System.Threading.ThreadState.WaitSleepJoin;
        }


        // Method to select Thread state option
        public static void CheckThreadState(string threadOption)
        {
            switch (threadOption)
            {
                case "1":
                    {
                        Console.WriteLine($"\n\t Is this thread Alive ?\t Response: {0}", CheckThreadAlive(thread));
                    }
                    break;

                case "2":
                    {
                        Console.WriteLine($"\n\t Is this thread Sleeping ?\t Response: {0}", CheckThreadSleeping(thread));
                    }
                    break;

                default:
                    {
                        Console.WriteLine("You entered an invalid option! try again: ");
                        CheckThreadState(threadOption);
                    }
                    break;
            }
        }
    }
}



