using System;
using System.Collections.Generic;
using System.Linq;

namespace data_structures
{
    public static class QueueExample
    {
        public static Queue<string> myQueue = new Queue<string>();

        public static void queueMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("QUEUE MENU");
            Console.WriteLine("1. Add one item to Queue");
            Console.WriteLine("2. Add Huge List of Items to Queue");
            Console.WriteLine("3. Display Queue");
            Console.WriteLine("4. Delete from Queue");
            Console.WriteLine("5. Clear Queue");
            Console.WriteLine("6. Search Queue");
            Console.WriteLine("7. Return to Main Menu");
            Console.ResetColor();

            try
            {
                Program.iInput = Convert.ToInt32(Console.ReadLine());

                switch (Program.iInput)
                {
                    case 1:
                        addOneQueue();
                        break;
                    case 2:
                        addManyQueue();
                        break;
                    case 3:
                        displayQueue();
                        break;
                    case 4:
                        deleteFromQueue();
                        break;
                    case 5:
                        clearQueue();
                        break;
                    case 6:
                        searchQueue();
                        break;
                    case 7:
                        Program.menu();
                        break;
                    default:
                        break;
                }

            }
            catch
            {
                Program.menu();
            }
        }
        public static void addOneQueue()
        {
            Console.Write("What would you like to add to the queue? ");
            myQueue.Enqueue(Console.ReadLine());
            queueMenu();

        }
        public static void addManyQueue()
        {
            myQueue.Clear();
            for (int i = 1; i <= 20; i++)
            {
                myQueue.Enqueue("New Entry " + i);
            }
            queueMenu();
        }
        public static void displayQueue()
        {
            Console.WriteLine("");
            foreach (string el in myQueue)
            {
                Console.WriteLine(el);
            }
            queueMenu();
        }
        public static void deleteFromQueue()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DELETED: " + myQueue.Peek());
            Console.ForegroundColor = ConsoleColor.White;
            myQueue.Dequeue();
            queueMenu();
        }
        public static void clearQueue()
        {
            myQueue.Clear();
            queueMenu();
        }
        public static void searchQueue()
        {
            Console.Write("What item would you like to search for in the queue? ");
            Program.sInput = Console.ReadLine();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            for (int i = 0; i < myQueue.Count; i++)
            {
                if (myQueue.ElementAt(i) == Program.sInput)
                {
                    sw.Stop();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Found: \"" + Program.sInput + "\"Time: " + sw.Elapsed);
                    Console.ForegroundColor = ConsoleColor.White;
                    queueMenu();

                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Unable to find: \"" + Program.sInput + "\"");
            Console.ForegroundColor = ConsoleColor.White;
            queueMenu();

        }
    }
}