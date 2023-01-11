using System;

namespace HockeyManager_namespace
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            string name;
            char position;
            int age, goals, hits, wins,i;
            var myHockeyManager = new HockeyManager();

            for (i = 0; i <= 3; i++) // dám to do cyklu, aby sa dalo zistiť najmladšieho brankára, keďže nepoužívam databázu
            {
                Console.WriteLine("Enter the player's position [G/D/F]: ");
                position = Console.ReadLine()[0];

                    switch (position)
                    {
                        case 'G':
                            Console.WriteLine("Enter the player's name: ");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter the player's age: ");
                            age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the player's wins: ");
                            wins = int.Parse(Console.ReadLine());
                            myHockeyManager.AddNewGoalie(name, age, wins);
                            break;

                        case 'D':
                            Console.WriteLine("Enter the player's name: ");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter the player's age: ");
                            age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the player's hits: ");
                            hits = int.Parse(Console.ReadLine());
                            myHockeyManager.AddNewGoalie(name, age, hits);
                            break;

                        case 'F':
                            Console.WriteLine("Enter the player's name: ");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter the player's age: ");
                            age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the player's goals: ");
                            goals = int.Parse(Console.ReadLine());
                            myHockeyManager.AddNewGoalie(name, age, goals);
                            break;

                        default:
                            Console.WriteLine("You wrote wrong letter.");
                            break;
                    }
            }
            myHockeyManager.PrintNameAndAgeOfTheYoungestGoalie(); //testovanie danej metódy po zbehnutí všetkých cyklov
        }
    }
}
