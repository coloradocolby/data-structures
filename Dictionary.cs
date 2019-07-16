using System;
using System.Collections.Generic;

namespace data_structures
{
    public static class DictionaryExample
    {
        public static Dictionary<string, int> myDictionary = new Dictionary<string, int>();
        public static int dictCounter = 0;

        public static void dictionaryMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("DICTIONARY MENU");
            Console.WriteLine("1. Add one item to Dictionary");
            Console.WriteLine("2. Add Huge List of Items to Dictionary");
            Console.WriteLine("3. Display Dictionary");
            Console.WriteLine("4. Delete from Dictionary");
            Console.WriteLine("5. Clear Dictionary");
            Console.WriteLine("6. Search Dictionary");
            Console.WriteLine("7. Return to Main Menu");
            Console.ResetColor();


            try
            {
                Program.iInput = Convert.ToInt32(Console.ReadLine());

                switch (Program.iInput)
                {
                    case 1:
                        addOneDictionary();
                        break;
                    case 2:
                        addManyDictionary();
                        break;
                    case 3:
                        displayDictionary();
                        break;
                    case 4:
                        deleteFromDictionary();
                        break;
                    case 5:
                        clearDictionary();
                        break;
                    case 6:
                        searchDictionary();
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
        public static void addOneDictionary()
        {
            Console.Write("What would you like to add to the dictionary? ");
            dictCounter++;
            myDictionary.Add(Console.ReadLine(), dictCounter);
            dictionaryMenu();

        }
        public static void addManyDictionary()
        {
            myDictionary.Clear();
            dictCounter = 0;
            for (int i = 1; i <= 20; i++)
            {
                myDictionary.Add("New Entry " + i, i);
            }
            dictionaryMenu();
        }
        public static void displayDictionary()
        {
            Console.WriteLine("");
            foreach (object el in myDictionary)
            {
                Console.WriteLine(el);
            }
            dictionaryMenu();
        }
        public static void deleteFromDictionary()
        {
            Console.Write("What item would you like to delete from the dictionary? ");
            Program.sInput = Console.ReadLine();
            if (myDictionary.ContainsKey(Program.sInput))
            {
                myDictionary.Remove(Program.sInput);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("DELETED: " + Program.sInput);
                Console.ForegroundColor = ConsoleColor.White;
                dictionaryMenu();
            }
            else
            {
                Console.WriteLine("Cannot delete \"" + Program.sInput + "\" because it does not exit");
            }
            dictionaryMenu();
        }
        public static void clearDictionary()
        {
            myDictionary.Clear();
            dictCounter = 0;
            dictionaryMenu();
        }
        public static void searchDictionary()
        {
            Console.Write("What item would you like to search for in the dictionary? ");
            Program.sInput = Console.ReadLine();
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            if (myDictionary.ContainsKey(Program.sInput))
            {
                sw.Stop();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Found: \"" + Program.sInput + "\"Time: " + sw.Elapsed);
                Console.ForegroundColor = ConsoleColor.White;
                dictionaryMenu();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Unable to find: \"" + Program.sInput + "\"");
            Console.ForegroundColor = ConsoleColor.White;
            dictionaryMenu();

        }
    }
}