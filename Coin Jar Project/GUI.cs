using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_5_Project
{
    internal class GUI
    {
        int selected;
        string[] names;
        public GUI(string[] names)
        {
            this.names = names;
            selected = 0;

        }
        public static void printGUI(string[] names, int selected, out int choice)
        {
            bool breaker = true;
            choice = selected;
            while (breaker)
            {
                print(names, selected);
                ConsoleKeyInfo k = Console.ReadKey(true);

                if (k.Key == ConsoleKey.LeftArrow)
                {
                    if (selected == 0)
                    {
                        selected = names.Length - 1;
                        print(names, selected);
                    }
                    else
                    {
                        selected--;
                        print(names, selected);
                    }
                }
                if (k.Key == ConsoleKey.RightArrow)
                {
                    if (selected == names.Length - 1)
                    {
                        selected = 0;
                        print(names, selected);
                    }
                    else
                    {
                        selected++;
                        print(names, selected);
                    }
                }
                if (k.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine($"\nYou chose: {names[selected]}");
                    choice = selected;
                    breaker = false;
                }
            }
        }
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
        public static void print(string[] names, int selected)
        {
            ClearCurrentConsoleLine();
            Console.CursorVisible = false;
            for (int i = 0; i < names.Length; i++)
            {
                if (i == selected)
                {
                    Console.Write("\x1B[7m{0}\x1B[27m   ", names[i]);
                }
                else
                {
                    Console.Write("\x1B[27m{0}   ", names[i]);
                }
            }
        }
    }
}