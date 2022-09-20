using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class MainMenu : Menu
    {
        public MainMenu()
        {
            base.title = "MAIN MENU";
            Console.WriteLine(base.title);
            DisplayOptions();
            MenuOptions();
            
        }
        public override void DisplayOptions()
        {
            Console.WriteLine("1. Experience/Job History");
            Console.WriteLine("2. Education/Training");
            Console.WriteLine("3. Skills");
            Console.WriteLine("4. Technological Skills");
            Console.WriteLine("5. Contact Details");
            Console.WriteLine("0. Exit\n");
        }

        public override void MenuOptions()
        {
            while (true)
            {
                Console.Write("Enter Choice: ");
                var choice = Console.ReadLine();

                switch (Convert.ToInt32(choice))
                {
                    case 0:
                        System.Environment.Exit(0);
                        break;
                    case 1:
                        Console.Clear();
                        JobExperienceMenu jobMenu = new JobExperienceMenu();
                        break;
                    case 2:
                        Console.Clear();
                        EducationMenu educationMenu = new EducationMenu();
                        break;
                    case 3:
                        Console.WriteLine("SKILLS:");
                        Skills skills = new Skills();
                        break;
                    case 4:
                        Console.WriteLine("TECHNICAL SKILLS:");
                        TechnicalSkills techSkills = new TechnicalSkills();
                        break;
                    case 5:
                        Console.WriteLine("CONTACT DETAILS:");
                        ContactDetails contact = new ContactDetails();
                        break;
                    default:
                        Console.Clear();
                        MainMenu mainMenu = new MainMenu();
                        break;
                }
            }
        }
    }
}
