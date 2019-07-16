using System;
using System.Collections.Generic;
using System.Linq;

namespace data_structures
{
    class StackExample
    {
        public static Stack<string> myStack = new Stack<string>();

        public static void stackMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("STACK MENU");
            Console.WriteLine("1. Add one item to Stack");
            Console.WriteLine("2. Add Huge List of Items to Stack");
            Console.WriteLine("3. Display Stack");
            Console.WriteLine("4. Delete from Stack");
            Console.WriteLine("5. Clear Stack");
            Console.WriteLine("6. Search Stack");
            Console.WriteLine("7. Return to Main Menu");
            Console.ResetColor();

            try
            {
                Program.iInput = Convert.ToInt32(Console.ReadLine());

                switch (Program.iInput)
                {
                    case 1:
                        addOneStack();
                        break;
                    case 2:
                        addManyStack();
                        break;
                    case 3:
                        displayStack();
                        break;
                    case 4:
                        deleteFromStack();
                        break;
                    case 5:
                        clearStack();
                        break;
                    case 6:
                        searchStack();
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
        public static void addOneStack()
        {
            Console.Write("What would you like to add to the stack? ");
            myStack.Push(Console.ReadLine());
            stackMenu();

        }
        public static void addManyStack()
        {
            myStack.Clear();
            for (int i = 1; i <= 20; i++)
            {
                myStack.Push("New Entry " + i);
            }
            stackMenu();
        }
        public static void displayStack()
        {
            Console.WriteLine("");
            foreach (string el in myStack)
            {
                Console.WriteLine(el);
            }
            stackMenu();
        }
        public static void deleteFromStack()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("DELETED: " + myStack.Peek());
            Console.ForegroundColor = ConsoleColor.White;
            myStack.Pop();
            stackMenu();
        }
        public static void clearStack()
        {
            myStack.Clear();
            stackMenu();
        }
        public static void searchStack()
        {
            Console.Write("What item would you like to search for in the stack? ");
            Program.sInput = Console.ReadLine();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            for (int i = 0; i < myStack.Count(); i++)
            {
                if (myStack.ElementAt(i) == Program.sInput)
                {
                    sw.Stop();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Found: \"" + Program.sInput + "\"Time: " + sw.Elapsed);
                    Console.ForegroundColor = ConsoleColor.White;
                    stackMenu();

                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Unable to find: \"" + Program.sInput + "\"");
            Console.ForegroundColor = ConsoleColor.White;
            stackMenu();

        }
    }
}