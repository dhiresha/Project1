using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class JobExperienceMenu : Menu
    {
        public JobExperienceMenu()
        {
            base.title = "JOB EXPERIENCE MENU";
            Console.WriteLine(base.title);
            DisplayOptions();
            MenuOptions();
        }
        public override void DisplayOptions()
        {
            Console.WriteLine("\n1. Internship - Ceridian (2022)");
            Console.WriteLine("\nGo back(press 'b')\n");
        }

        public override void MenuOptions()
        {
            while (true)
            {
                Console.Write("Enter choice: ");
                var choice = Console.ReadLine();

                GoBack(choice);

                switch (Convert.ToInt32(choice))
                {
                    case 1:
                        Console.WriteLine("Training session on .NET, C#, Web...\n");
                        break;
                    default:
                        Console.Clear();
                        JobExperienceMenu jobMenu = new JobExperienceMenu();
                        break;
                }
            }
        }
    }
}
