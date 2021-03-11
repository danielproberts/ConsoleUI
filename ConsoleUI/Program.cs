using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuItems = { "File", "Edit", "View", "Project", "Build", "Debug", "Test", "Analyze", "Tools", "Window", "Help" };


            ConUI.CenterTitle("Sample Menu");

            ConUI.GenerateBarMenu(menuItems);
            Console.ReadKey();
        }
    }
}
