using System;
using Ex04.Menus.Interfaces.Interfaces;

namespace Ex04.Menus.Interfaces
{   
    public class ActiveItem : MenuItem
    {
        private Notifier doActionNotifier;

        public ActiveItem(string i_Title, Menu i_PreviousMenu) : base(i_Title, i_PreviousMenu)
        {
            doActionNotifier = new Notifier();
        }

        public void AddDoActionListener(IDoActionListener i_DoActionListener)
        {
            doActionNotifier.AddListener(i_DoActionListener);
        }

        public void RemoveDoActionListener(IDoActionListener i_DoActionListener)
        {
            doActionNotifier.RemoveListener(i_DoActionListener);
        }

        public override void Show()
        {
            Console.Clear();
            doActionNotifier.notifiyAll();
            System.Threading.Thread.Sleep(2500);
            PreviousMenu.Show();
        }
    }
}
