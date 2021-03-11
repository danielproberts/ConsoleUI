using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            string[] menuItems = { "File", "Edit", "View", "Project", "Build", "Debug", "Analyze", "Tools", "Window", "Help" };
            string[] subMenuItems = { "New", "Open", "Save", "Save As", "Exit" };
            string menuChoice;

            ConUI.CenterTitle("Sample Menu");

            ConUI.GenerateBarMenu(menuItems);
            //ConUI.SubBarMenu(menuItems, "View", subMenuItems);

            Console.SetCursorPosition(0, 25);

            Console.Write("Please select a menu option: _");
            Console.SetCursorPosition(29, 25);

            menuChoice = Console.ReadLine();
            while(menuChoice != "X")
            {
                if(menuChoice == "F")
                {
                    Console.Clear();
                    ConUI.CenterTitle("Sample Menu");
                    ConUI.GenerateBarMenu(menuItems);
                    ConUI.SubBarMenu(menuItems, "File", subMenuItems);
                }
                else if(menuChoice == "E")
                {
                    Console.Clear();
                    ConUI.CenterTitle("Sample Menu");
                    ConUI.GenerateBarMenu(menuItems);
                    ConUI.SubBarMenu(menuItems, "Edit", subMenuItems);
                }
                Console.SetCursorPosition(0, 25);

                Console.Write("Please select a menu option: _");
                Console.SetCursorPosition(29, 25);
                menuChoice = Console.ReadLine();
            }

        }
    }
}
