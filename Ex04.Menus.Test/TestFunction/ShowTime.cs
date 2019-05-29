﻿using System;
using Ex04.Menus.Interfaces.Interfaces;

namespace Ex04.Menus.Test.TestFunction
{
    public class ShowTime : IDoActionListener
    {
        public void DoAction()
        {
            ShowTimeAction();
        }

        private void ShowTimeAction()
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
    }
}
