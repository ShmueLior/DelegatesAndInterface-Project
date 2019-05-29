using System;

namespace Ex04.Menus.Delegates
{
    public delegate void ActiveMenuItemNotifier();

    public class ActiveItem : MenuItem
    {
        public event ActiveMenuItemNotifier ActionHandler;

        public ActiveItem(string i_Title, Menu i_PreviousMenu) : base(i_Title, i_PreviousMenu)
        {
        }

        public override void Show()
        {
            Console.Clear();
            OnAction();
            System.Threading.Thread.Sleep(2500);
            PreviousMenu.Show();
        }

        private void OnAction()
        {
            if (ActionHandler != null)
            {
                ActionHandler.Invoke();
            }
        }
    }
}