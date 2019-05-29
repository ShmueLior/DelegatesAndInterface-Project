﻿namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        private readonly Menu r_PreviousMenu;
        private string m_Titel;

        public MenuItem(string i_Titel, Menu i_PreviousMenu)
        {
            m_Titel = i_Titel;
            r_PreviousMenu = i_PreviousMenu;
        }

        public string Title
        {
            get { return m_Titel; }
            set { m_Titel = value; }
        }

        public Menu PreviousMenu
        {
            get { return r_PreviousMenu; }
        }

        public abstract void Show();
    }
}
