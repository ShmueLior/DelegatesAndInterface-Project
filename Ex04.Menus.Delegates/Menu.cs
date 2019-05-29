using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public abstract class Menu : MenuItem
    {
        private readonly List<MenuItem> r_MenuItems;
        private readonly string r_EscPrint;

        public Menu(string i_Title, Menu i_PreviousMenu, string i_EscPrint) : base(i_Title, i_PreviousMenu)
        {
            r_MenuItems = new List<MenuItem>();
            r_EscPrint = i_EscPrint;
        }

        public List<MenuItem> SubMenu
        {
            get { return r_MenuItems; }
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            r_MenuItems.Add(i_MenuItem);
        }

        public void RemoveMenuItem(MenuItem i_MenuItem)
        {
            r_MenuItems.Remove(i_MenuItem);
        }

        public override void Show()
        {
            Console.Clear();
            showMenu();
            int userChoice = getChoiseFromUser();
            doAccordingToChoice(userChoice);
        }

        private void showMenu()
        {
            int itrIndex = 1;
            Console.WriteLine(Title);
            Console.WriteLine("{0}) {1}", 0, r_EscPrint);
            foreach (MenuItem menuItem in r_MenuItems)
            {
                Console.WriteLine("{0}) {1}", itrIndex, menuItem.Title);
                itrIndex++;
            }
        }

        private int getChoiseFromUser()
        {
            bool validInput = false;
            int userInput = -1;
            while (!validInput)
            {
                Console.WriteLine("Choose an option from the menu:");
                validInput = int.TryParse(Console.ReadLine(), out userInput);
                validInput = validInput && userInput >= 0 && userInput <= r_MenuItems.Count;
                if (!validInput)
                {
                    Console.WriteLine("Unvalid input, please choose a number: (from the range {0} to {1})", 0, r_MenuItems.Count);
                }
            }

            return userInput;
        }

        private void doAccordingToChoice(int i_UserChoice)
        {
            if (i_UserChoice == 0)
            {
                if (this is MainMenu)
                {
                    Console.Clear();
                    Console.WriteLine("GoodBye!");
                    System.Threading.Thread.Sleep(3000);
                    return;
                }
                else if (this is SubMenu)
                {
                    PreviousMenu.Show();
                }
            }
            else
            {
                r_MenuItems[i_UserChoice - 1].Show();
            }
        }
    }
}
