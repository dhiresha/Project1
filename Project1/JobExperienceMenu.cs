using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class JobExperienceMenu
    {
        public JobExperienceMenu()
        {
            JobMenu();
        }

        private void JobMenu()
        {
            Console.WriteLine("JOB HISTORY / EXPERIENCE");
            Console.WriteLine("1. Internship - Ceridian (2022)");
            Console.WriteLine("\nGo back(press 'b')\n");

            while (true)
            {
                Console.Write("Enter choice: ");
                var choice = Console.ReadLine();

                if (choice == "b")
                {
                    Console.Clear();
                    MainMenu mainMenu = new MainMenu();
                    break;
                }
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
