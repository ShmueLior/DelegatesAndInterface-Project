using Ex04.Menus.Delegates;
using Ex04.Menus.Test.TestFunction;

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

        public void BuildMenu()
        {
            SubMenu subMenu = new SubMenu("Show Date / Time", r_MainMenu);

            ActiveItem activeItem = new ActiveItem("Show Date", subMenu);
            activeItem.Notifier += new ShowDate().DoAction;
            subMenu.AddMenuItem(activeItem);

            activeItem = new ActiveItem("Show Time", subMenu);
            activeItem.Notifier += new ShowTime().DoAction;
            subMenu.AddMenuItem(activeItem);

            r_MainMenu.AddMenuItem(subMenu);

            subMenu = new SubMenu("Version and Digits", r_MainMenu);

            activeItem = new ActiveItem("Count Digits", subMenu);
            activeItem.Notifier += new CountDigits().DoAction;
            subMenu.AddMenuItem(activeItem);

            activeItem = new ActiveItem("Show Version", subMenu);
            activeItem.Notifier += new ShowVersion().DoAction;
            subMenu.AddMenuItem(activeItem);

            r_MainMenu.AddMenuItem(subMenu);
        }

        public void StartMenu()
        {
            r_MainMenu.Show();
        }
    }
}
