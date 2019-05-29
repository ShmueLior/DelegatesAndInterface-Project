namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            TestInterface testInterface = new TestInterface();
            TestDelegates testDelegates = new TestDelegates();
            testInterface.StartMenu();
            testDelegates.StartMenu();
        }
    }
}
