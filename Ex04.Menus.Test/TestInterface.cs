using Ex04.Menus.Interfaces;
using Ex04.Menus.Interfaces.Interfaces;
using Ex04.Menus.Test.TestFunction;

namespace Ex04.Menus.Test
{
    public class TestInterface
    {
        private readonly MainMenu r_MainMenu;

        public TestInterface()
        {
            r_MainMenu = new MainMenu("This is the start of the INTERFACE menu");
            BuildMenu();
        }

        public void BuildMenu()
        {
            SubMenu subMenu = new SubMenu("Show Date / Time", r_MainMenu);

            ActiveItem activeItem = new ActiveItem("Show Date", subMenu);
            activeItem.AddDoActionListener(new ShowDate() as IDoActionListener);
            subMenu.AddMenuItem(activeItem);

            activeItem = new ActiveItem("Show Time", subMenu);
            activeItem.AddDoActionListener(new ShowTime() as IDoActionListener);
            subMenu.AddMenuItem(activeItem);

            r_MainMenu.AddMenuItem(subMenu);

            subMenu = new SubMenu("Version and Digits", r_MainMenu);

            activeItem = new ActiveItem("Count Digits", subMenu);
            activeItem.AddDoActionListener(new CountDigits() as IDoActionListener);
            subMenu.AddMenuItem(activeItem);

            activeItem = new ActiveItem("Show Version", subMenu);
            activeItem.AddDoActionListener(new ShowVersion() as IDoActionListener);
            subMenu.AddMenuItem(activeItem);

            r_MainMenu.AddMenuItem(subMenu);
        }

        public void StartMenu()
        {
            r_MainMenu.Show();
        }
    }
}