using System;

namespace data_structures
{
    class Program
    {
        public static string sInput;
        public static int iInput;

        public static void menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("1. Stack");
            Console.WriteLine("2. Queue");
            Console.WriteLine("3. Dictionary");
            Console.WriteLine("4. Exit");
            Console.ResetColor();

            try
            {
                iInput = Convert.ToInt32(Console.ReadLine());

                switch (iInput)
                {
                    case 1:
                        StackExample.stackMenu();
                        break;
                    case 2:
                        QueueExample.queueMenu();
                        break;
                    case 3:
                        DictionaryExample.dictionaryMenu();
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }

            }
            catch
            {
                menu();
            }
        }

        static void Main(string[] args)
        {
            menu();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}