using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projettest
{
     public class Hero : Person
    {
        public int healLvl = 7, maxHealth = 70;
                      //energy

        public Hero(string pseudo, int _attack, int _health, int _armor, int _energy)   //energy
            : base(pseudo, _attack, _health, _armor)
        {
        }

        public void LevelUp()
        {
            Console.WriteLine("Vous avez gagné un niveau !");
            Console.WriteLine("Attaque +5");
            Console.WriteLine("PdV Max +10");
            Console.WriteLine("Soin +5");
            Console.WriteLine("Amure +1");
            Console.WriteLine("Energie Restaurée");                 //energy
            Console.ReadLine();
            Console.Clear();

            attack += 5;
            maxHealth += 10;
            health = maxHealth;
            healLvl += 10;
            armor += 1;
            MaxEnergy = 200;                        //energy
        }
        public void Divin()
        {
            Console.WriteLine("Vous devenez un être Divin !");
            Console.WriteLine("Attaque +50");
            Console.WriteLine("PdV Max +100");
            Console.WriteLine("Soin +50");
            Console.WriteLine("Amure +10");
            Console.WriteLine("Energie Restaurée");                 //energy
            Console.ReadLine();
            Console.Clear();

            attack += 50;
            maxHealth += 100;
            health = maxHealth;
            healLvl += 50;
            armor += 10;
            MaxEnergy = 200;                        //energy
        }

        public void Heal()
        {
            health += healLvl;

            if (health > maxHealth)
            {
                health = maxHealth;
            }
        }

        public void Shadow_Slash(Enemy target)
        {
            if (MaxEnergy >= 50)                    //energy
            {
                target.health -= ((attack - 2) * 3) - target.armor;
                MaxEnergy = MaxEnergy - 50;         //energy
            }
            else
            {
                target.health -= 0;
            }
        }

        public void Razor_Shuriken(Enemy target)
        {
            if (MaxEnergy >= 100)                   //energy
            {
                target.health -= attack * 2 - target.armor;
                MaxEnergy = MaxEnergy - 100;        //energy
            }
            else
            {
                target.health -= 0;
            }
        }

        
        public int Choice() 
        {
            bool correctInput = true;
            int choice = 0, choice2;
            while (correctInput)
            {
                Console.WriteLine("Que voulez-vous faire ?");
                Console.WriteLine("1. Attaque Basique");
                Console.WriteLine("2. Soin");
                Console.WriteLine("3. Attaques Speciales");
                Console.WriteLine("4. sauvegarde");

                bool test = int.TryParse(Console.ReadLine(), out choice);
                if (!test || choice > 4 || choice <= 0)
                {
                    Console.WriteLine("Appuiez sur une touche valide !");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if (choice == 3)
                {
                    Console.WriteLine("Attaque Speciales:");
                    Console.WriteLine("1. Shadow Slash ");
                    Console.WriteLine("2. Razor Shuriken");
                    Console.WriteLine("3. <--- Retour");

                    bool test2 = int.TryParse(Console.ReadLine(), out choice2);
                    if (!test2 || choice2 > 3 || choice2 <= 0)
                    {
                        Console.WriteLine("Appuiez sur une touche valide!");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    if (choice2 == 1)
                    {
                        choice = 4;
                    }

                    if (choice2 == 2)
                    {
                        choice = 5;
                    }
                    if (choice2 == 3)
                    {
                        choice = 6;
                    }
                }

                if (choice == 1 || choice == 2 || choice == 4 || choice == 5 || choice == 6)
                {
                    break;
                }
            }
            return choice;
        }

        public void YourTurn(int decision, Enemy target)
        {
            if (decision == 1)
            {
                NormAttack(target);
                Console.WriteLine("Vous frappez l'ennemi!");
            }

            if (decision == 2)
            {
                Heal();
                Console.WriteLine("Vous vous êtes soigné {0} point de vie!", healLvl);
            }

            if (decision == 4)
            {
                Shadow_Slash(target);
                Console.WriteLine("Vous lancez Shadow Slash (coût 50 en énergie) !");
                Console.WriteLine("si vous n'avez plus dénergie le sort ne fait pas de dégat");
            }

            if (decision == 5)
            {
                Razor_Shuriken(target);
                Console.WriteLine("Vous lancez Razor Shurkien (coût 100 en énergie) !");
                Console.WriteLine("si vous n'avez plus dénergie le sort ne fait pas de dégat");
            }
             if (decision == 6)
            {
                //SaveGame();
            }

        }
    }
}
