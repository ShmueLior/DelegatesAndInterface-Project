using System;
using Ex04.Menus.Interfaces.Interfaces;

namespace Ex04.Menus.Test.TestFunction
{
    public class ShowVersion : IDoActionListener
    {
        public void DoAction()
        {
            ShowVersionAction();
        }

        private void ShowVersionAction()
        {
            Console.WriteLine("Version: 19.2.4.32");
        }
    }
}
