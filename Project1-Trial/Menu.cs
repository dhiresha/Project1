using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal abstract class Menu
    {
        public string title { get; set; }
        public abstract void DisplayOptions();
        public abstract void MenuOptions();
        public bool GoBack(string choice)
        {
            if(choice == "b")
            {
                Console.Clear();
                MainMenu mainMenu = new MainMenu();
                return true;
            }
            else
                return false;
        }
    }
}
