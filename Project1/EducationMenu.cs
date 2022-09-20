using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class EducationMenu
    {
        public EducationMenu()
        {
            EducMenu();
        }

        private void EducMenu()
        {
            Console.WriteLine("EDUCATION MENU");
            Console.WriteLine("1. Software Engineering (Year 1)");
            Console.WriteLine("2. Software Engineering (Year 2)");
            Console.WriteLine("\nGo Back(press b)");


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
                        Console.WriteLine("\nModules done in Year 1: ");
                        Console.WriteLine("1. Software Aanalysis and Modelling\n" +
                            "2. Software Engineering Principles\n" +
                            "3. Database Systems\n" +
                            "4. Software Design Fundamentals and Programming\n" +
                            "5. Discrete Structures\n" +
                            "6. Communication and Business skills for IT\n");
                        break;
                    case 2:
                        Console.WriteLine("\nModules done in Year 2: ");
                        Console.WriteLine("1. Object-Oriented Software Development\n" +
                            "2. Software Verification and Validation\n" +
                            "3. Data Structures and Algorithms\n" +
                            "4. Software Project Management\n" +
                            "5. Interactive Systems Design\n" +
                            "6. Web Application Development\n");
                        break;
                    default:
                        Console.Clear();
                        EducationMenu educMenu = new EducationMenu();
                        break;
                }
            }
        }
    }
}
