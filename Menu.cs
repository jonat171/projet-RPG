using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projettest
{
    class Menu
    {
        public static void MainMenu()
        {
            PrintMenu();
            int userChoice = AskChoice(1, 4);
            switch (userChoice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("You start the game");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Load"); //Todo fonction chargement partie
                    Console.ReadLine();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("On s'en fou sort d'ici et va jouer");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Quit");
                    Environment.Exit(0);
                    break;

                default:
                    break;
            }
        }
        public static int AskChoice(int min, int max)
        {
            int result = int.Parse(Console.ReadLine());
            while (result > max || result < min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;
        }
        public static void PrintMenu()
        {
            Console.WriteLine("Welcome to this game!");
            Console.WriteLine("1. Start the game");
            Console.WriteLine("2. Load");
            Console.WriteLine("3. About");
            Console.WriteLine("4. Quit");

        }
    }
}

