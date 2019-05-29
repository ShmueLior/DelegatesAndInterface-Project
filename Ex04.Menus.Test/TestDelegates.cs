using System;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{   
    public class TestDelegates
    {
        private readonly MainMenu r_MainMenu;

        public TestDelegates()
        {
            r_MainMenu = new MainMenu("This is the start of the DELEGATES menu");
            BuildMenu();
        }

        public void CountDigits()
        {
            int countDigits = 0;
            Console.WriteLine("Please enter string:");
            string inputString = Console.ReadLine();
            foreach (char charIter in inputString)
            {
                if (char.IsDigit(charIter))
                {
                    countDigits++;
                }
            }

            Console.WriteLine("There are {0} digits in your input string", countDigits);
        }

        public void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }

        public void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }

        public void ShowVersion()
        {
            Console.WriteLine("Version: 19.2.4.32");
        }

        public void BuildMenu()
        {
            SubMenu subMenu = new SubMenu("Show Date / Time", r_MainMenu);

            ActiveItem activeItem = new ActiveItem("Show Date", subMenu);
            activeItem.Notifier += this.ShowDate;
            subMenu.AddMenuItem(activeItem);

            activeItem = new ActiveItem("Show Time", subMenu);
            activeItem.Notifier += this.ShowTime;
            subMenu.AddMenuItem(activeItem);

            r_MainMenu.AddMenuItem(subMenu);

            subMenu = new SubMenu("Version and Digits", r_MainMenu);

            activeItem = new ActiveItem("Count Digits", subMenu);
            activeItem.Notifier += this.CountDigits;
            subMenu.AddMenuItem(activeItem);

            activeItem = new ActiveItem("Show Version", subMenu);
            activeItem.Notifier += this.ShowVersion;
            subMenu.AddMenuItem(activeItem);

            r_MainMenu.AddMenuItem(subMenu);
        }

        public void StartMenu()
        {
            r_MainMenu.Show();
        }
    }
}
