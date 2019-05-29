using System;
using Ex04.Menus.Interfaces.Interfaces;

namespace Ex04.Menus.Interfaces.Listeners
{
    public class ShowDate : IDoActionListener
    {
        public void DoAction()
        {
            ShowDateAction();
        }

        private void ShowDateAction()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
    }
}
