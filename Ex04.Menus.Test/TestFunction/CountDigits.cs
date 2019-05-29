using System;
using Ex04.Menus.Interfaces.Interfaces;

namespace Ex04.Menus.Test.TestFunction
{
    public class CountDigits : IDoActionListener
    {
        public void DoAction()
        {
            CountDigitsAction();
        }

        private void CountDigitsAction()
        {
            int countDigits = 0;
            Console.WriteLine("Please enter string:");
            string inputString = Console.ReadLine();
            foreach (char charIter in inputString)
            {
                if (char.IsDigit(charIter))
                {
                    countDigits++;
                }
            }

            Console.WriteLine("There are {0} digits in your input string", countDigits);
        }
    }
}