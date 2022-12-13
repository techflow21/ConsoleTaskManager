namespace ConsoleTaskManager
{
    internal class Utility
    {
        public static void AppName()
        {
            Console.WriteLine("\n  >>>>>>>> Welcome to Console Tasks Manager <<<<<<<< ");
        }

        public static void ContinueOption()
        {
            Console.WriteLine("\n\t Do you want to continue (Y/N)? \n");
            var option = Console.ReadLine();

            switch (option.ToUpper())
            {
                case "Y":
                    {
                        TaskOption.TaskOptions();
                    }
                    break;

                case "N":
                    {
                        Console.WriteLine("\n\t Thanks for using this Console Task Manager");
                    }
                    break;

                default:
                    {
                        Console.WriteLine("You entered an invalid option! try again: ");
                        ContinueOption();
                    }
                    break;
            }
        }
    }
}
