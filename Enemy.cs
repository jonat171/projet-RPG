using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projettest
{
    public class Enemy : Person
    {
        public int numOfAttack;

        public Enemy(string _name, int _attack, int _health, int _armor)
            : base(_name, _attack, _health, _armor)
        {
        }

        

        public int EChoice()
        {
            int eChoice;
            Random ran = new Random();
            eChoice = ran.Next(1, numOfAttack + 1);
            return eChoice;
        }
    }

    public class Gobelin : Enemy
    {
        public Gobelin(string _name, int _attack, int _health, int _armor)
            : base(_name, _attack, _health, _armor)
        {
            numOfAttack = 2;
        }

        

        public void Cure_Dent(Hero target)
        {
            target.health -= attack + 2 - target.armor;
        }

        public void GobelinTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("Le Gobelin t'as frappé!");

            }

            if (choice == 2)
            {
                Cure_Dent(target);
                Console.WriteLine("Le Gobelin lance Cure Dent!");

            }

            Console.ReadLine();
            Console.Clear();
        }
    }

    public class Loup : Enemy
    {
        public Loup(string _name, int _attack, int _health, int _armor)
            : base(_name, _attack, _health, _armor)
        {
            numOfAttack = 2;
        }

        

        public void Griffe(Hero target)
        {
            target.health -= attack + 2 - target.armor;
        }

        public void LoupTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("Le Loup t'as sévèrement mordu!");

            }

            if (choice == 2)
            {
                Griffe(target);
                Console.WriteLine("Le Loup t'as découpé!");

            }

            Console.ReadLine();
            Console.Clear();
        }
    }

    public class Ours : Enemy
    {
        public Ours(string _name, int _attack, int _health, int _armor)
            : base(_name, _attack, _health, _armor)
        {
            numOfAttack = 2;
        }

        

        public void Ecrasement(Hero target)
        {
            target.health -= attack + 2 -target.armor;
        }

        public void OursTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("L'Ours t'as frappé!");

            }

            if (choice == 2)
            {
                Ecrasement(target);
                Console.WriteLine("L'Ours se roule sur toi de tout son poids!");

            }

            Console.ReadLine();
            Console.Clear();
        }
    }

    public class Chimere : Enemy
        {
            public Chimere(string _name, int _attack, int _health, int _armor)
                : base(_name, _attack, _health, _armor)
            {
                numOfAttack = 2;
            }

           

            public void Souffle_Ardent(Hero target)
            {
                target.health -= attack + 2 - target.armor;
            }

            public void ChimereTurn(int choice, Hero target)
            {
                if (choice == 1)
                {
                    NormAttack(target);
                    Console.WriteLine("La Chimère frappe de toute ses forces!");

                }

                if (choice == 2)
                {
                    Souffle_Ardent(target);
                    Console.WriteLine("La Chimère lance Souffle Ardent!");

                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        public class Scorpion : Enemy
        {
            public Scorpion(string _name, int _attack, int _health, int _armor)
                : base(_name, _attack, _health, _armor)
            {
                numOfAttack = 2;
            }

           

            public void Piqure(Hero target)
            {
                
                target.health -= attack + 2 -target.armor;
            }

            public void ScorpionTurn(int choice, Hero target)
            {
                if (choice == 1)
                {
                    NormAttack(target);
                    Console.WriteLine("Le Scorpion t'as pincé!");

                }

                if (choice == 2)
                {
                    Piqure(target);
                    Console.WriteLine("Le Scorpion t'as piqué!");

                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        public class Ver_Des_Sables : Enemy
        {
            public Ver_Des_Sables(string _name, int _attack, int _health, int _armor)
                : base(_name, _attack, _health, _armor)
            {
                numOfAttack = 2;
            }

            

            public void Tempete_De_Sable(Hero target)
            {
                target.health -= attack + 2 -target.armor;
            }

            public void Ver_Des_SablesTurn(int choice, Hero target)
            {
                if (choice == 1)
                {
                    NormAttack(target);
                    Console.WriteLine("Le Ver_Des_Sables t'as frappé !");

                }

                if (choice == 2)
                {
                    Tempete_De_Sable(target);
                    Console.WriteLine("Le Ver_Des_Sables génère une violente tempête de sable !");

                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        public class Singe : Enemy
        {
            public Singe(string _name, int _attack, int _health, int _armor)
                : base(_name, _attack, _health, _armor)
            {
                numOfAttack = 2;
            }

            

            public void Fais_Une_Grimace(Hero target)
            {
                target.health -= attack + 2 -target.armor;
            }

            public void SingeTurn(int choice, Hero target)
            {
                if (choice == 1)
                {
                    NormAttack(target);
                    Console.WriteLine("Le Singe vous lance une noix de coco ");

                }

                if (choice == 2)
                {
                    Fais_Une_Grimace(target);
                    Console.WriteLine("Le Singe t'as humilié, vous êtes vexé !");

                }

                Console.ReadLine();
                Console.Clear();
            }
        }

        public class Frere : Enemy
        {
            public Frere(string _name, int _attack, int _health, int _armor)
                : base(_name, _attack, _health, _armor)
            {
                numOfAttack = 2;
            }

            

            public void Oups(Hero target)
            {
                target.health -= attack + 2 -target.armor;
            }

            public void FrereTurn(int choice, Hero target)
            {
                if (choice == 1)
                {
                    NormAttack(target);
                    Console.WriteLine("Votre Frere vous victimise");

                }

                if (choice == 2)
                {
                    Oups(target);
                    Console.WriteLine("Votre Frere appelle ses parents!");

                }

                Console.ReadLine();
                Console.Clear();
            }
        } 
    }
