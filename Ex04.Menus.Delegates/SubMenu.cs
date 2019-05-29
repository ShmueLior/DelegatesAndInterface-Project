namespace Ex04.Menus.Delegates
{
    public class SubMenu : Menu
    {
        public SubMenu(string i_Title, Menu i_PreviousMenu) : base(i_Title, i_PreviousMenu, "Back")
        {
        }
    }
}
