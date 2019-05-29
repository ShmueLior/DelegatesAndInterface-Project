using Ex04.Menus.Interfaces;
using Ex04.Menus.Interfaces.Interfaces;
using Ex04.Menus.Interfaces.Listeners;

namespace Ex04.Menus.Test
{
    public class TestInterface
    {
        private MainMenu m_MainMenu;

        public TestInterface()
        {
            m_MainMenu = new MainMenu("This is the start of the INTERFACE menu");
            BuildMenu();
        }

        public void BuildMenu()
        {
            SubMenu subMenu = new SubMenu("Show Date / Time", m_MainMenu);

            ActiveItem activeItem = new ActiveItem("Show Date", subMenu);
            activeItem.AddDoActionListener(new ShowDate() as IDoActionListener);
            subMenu.AddMenuItem(activeItem);

            activeItem = new ActiveItem("Show Time", subMenu);
            activeItem.AddDoActionListener(new ShowTime() as IDoActionListener);
            subMenu.AddMenuItem(activeItem);

            m_MainMenu.AddMenuItem(subMenu);

            subMenu = new SubMenu("Version and Digits", m_MainMenu);

            activeItem = new ActiveItem("Count Digits", subMenu);
            activeItem.AddDoActionListener(new CountDigits() as IDoActionListener);
            subMenu.AddMenuItem(activeItem);

            activeItem = new ActiveItem("Show Version", subMenu);
            activeItem.AddDoActionListener(new ShowVersion() as IDoActionListener);
            subMenu.AddMenuItem(activeItem);

            m_MainMenu.AddMenuItem(subMenu);
        }

        public void StartMenu()
        {
            m_MainMenu.Show();
        }
    }
}