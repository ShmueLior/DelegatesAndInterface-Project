using System.Collections.Generic;
using Ex04.Menus.Interfaces.Interfaces;

namespace Ex04.Menus.Interfaces
{
    public class Notifier
    {
        private List<IDoActionListener> m_Listeners;

        public Notifier()
        {
            m_Listeners = new List<IDoActionListener>();
        }

        public void AddListener(IDoActionListener i_Listener)
        {
            m_Listeners.Add(i_Listener);
        }

        public void RemoveListener(IDoActionListener i_Listener)
        {
            m_Listeners.Remove(i_Listener);
        }

        public void notifiyAll()
        {
            foreach (IDoActionListener actionListener in m_Listeners)
            {
                actionListener.DoAction();
            }
        }
    }
}
