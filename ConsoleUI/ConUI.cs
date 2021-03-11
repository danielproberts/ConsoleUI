using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class ConUI
    {
        public ConUI()
        {

        }

        public static void CenterTitle(string s)
        {
            string windowHeader = s;
            Console.SetCursorPosition((Console.WindowWidth - windowHeader.Length) / 2, Console.CursorTop);
            Console.WriteLine(windowHeader);
        }

        public static void GenerateListMenu(string[] menuOptions)
        {
            var currentItem = 1;
            foreach (var item in menuOptions)
            {
                Console.Write($"{currentItem}) ");
                Console.WriteLine(item);
                currentItem+=1;
            }
        }

        public static void GenerateBarMenu(string[] menuOptions)
        {
            var menuLength = 0;
            var menuOutput = "";
            foreach(var item in menuOptions)
            {
                menuLength += item.Length;
            }



            var numOfItems = menuOptions.Length;
            //Console.SetCursorPosition((Console.WindowWidth) / numOfItems, Console.CursorTop);
            foreach(var item in menuOptions)
            {
                menuOutput += item;
                menuOutput = menuOutput.PadRight(menuOutput.Length + (menuLength/numOfItems));
            }
            Console.WriteLine(menuOutput);
        }
    }
}