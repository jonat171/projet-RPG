using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projettest
{
    class Battle
    {
        public static void IsHeroDead(Hero hero)
        {
            if (hero.health <= 0)
            {
                Console.Clear();
                Console.WriteLine("Vous n'avez aucun talent !");
                Console.WriteLine("Vous aurez peut-être plus de chance la prochaine fois !");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
        public static void PrintTheStats(Person person1, Person person2)
        {
            person1.PrintStats();
            Console.WriteLine("");
            person2.PrintStats();
            Console.WriteLine("");
        }

        public static void WithGobelin(Hero hero, Gobelin gobelin)
        {
            while (gobelin.health > 0 && hero.health > 0)
            {
                PrintTheStats(gobelin, hero);

                hero.YourTurn(hero.Choice(), gobelin);

                if (gobelin.health > 0)
                {
                    gobelin.GobelinTurn(gobelin.EChoice(), hero);
                    IsHeroDead(hero);
                }

            }

            Console.WriteLine("{0} a été tué!", gobelin.name);
            Console.ReadLine();
            Console.Clear();
        }
        public static void WithLoup(Hero hero, Loup loup)
        {
            while (loup.health > 0 && hero.health > 0)
            {
                PrintTheStats(loup, hero);

                hero.YourTurn(hero.Choice(), loup);

                if (loup.health > 0)
                {
                    loup.LoupTurn(loup.EChoice(), hero);
                    IsHeroDead(hero);
                }

            }

            Console.WriteLine("{0} a été tué!", loup.name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithOurs(Hero hero, Ours ours)
        {
            while (ours.health > 0 && hero.health > 0)
            {
                PrintTheStats(ours, hero);

                hero.YourTurn(hero.Choice(), ours);

                if (ours.health > 0)
                {
                    ours.OursTurn(ours.EChoice(), hero);
                    IsHeroDead(hero);
                }

            }

            Console.WriteLine("{0} s'est fait lapider!", ours.name);
            Console.ReadLine();
            Console.Clear();
        }


        public static void WithChimere(Hero hero, Chimere chimere)
        {
            while (chimere.health > 0 && hero.health > 0)
            {
                PrintTheStats(chimere, hero);

                hero.YourTurn(hero.Choice(), chimere);

                if (chimere.health > 0)
                {
                    chimere.ChimereTurn(chimere.EChoice(), hero);
                    IsHeroDead(hero);
                }

            }

            Console.WriteLine("{0} a succombée!", chimere.name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithScorpion(Hero hero, Scorpion scorpion)
        {
            while (scorpion.health > 0 && hero.health > 0)
            {
                PrintTheStats(scorpion, hero);

                hero.YourTurn(hero.Choice(), scorpion);

                if (scorpion.health > 0)
                {
                    scorpion.ScorpionTurn(scorpion.EChoice(), hero);
                    IsHeroDead(hero);
                }

            }

            Console.WriteLine("{0} a été tué!", scorpion.name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithVer_Des_Sables(Hero hero, Ver_Des_Sables ver_Des_Sables)
        {
            while (ver_Des_Sables.health > 0 && hero.health > 0)
            {
                PrintTheStats(ver_Des_Sables, hero);

                hero.YourTurn(hero.Choice(), ver_Des_Sables);

                if (ver_Des_Sables.health > 0)
                {
                    ver_Des_Sables.Ver_Des_SablesTurn(ver_Des_Sables.EChoice(), hero);
                    IsHeroDead(hero);
                }

            }

            Console.WriteLine("{0} est retourné à la poussière!", ver_Des_Sables.name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithSinge(Hero hero, Singe singe)
        {
            while (singe.health > 0 && hero.health > 0)
            {
                PrintTheStats(singe, hero);

                hero.YourTurn(hero.Choice(), singe);

                if (singe.health > 0)
                {
                    singe.SingeTurn(singe.EChoice(), hero);
                    IsHeroDead(hero);
                }

            }

            Console.WriteLine("{0} a été tué!", singe.name);
            Console.ReadLine();
            Console.Clear();
        }

        public static void WithFrere(Hero hero, Frere frere)
        {
            while (frere.health > 0 && hero.health > 0)
            {
                PrintTheStats(frere, hero);

                hero.YourTurn(hero.Choice(), frere);

                if (frere.health > 0)
                {
                    frere.FrereTurn(frere.EChoice(), hero);
                    IsHeroDead(hero);
                }

            }

            Console.WriteLine("{0} ne fais plus le malin!", frere.name);
            Console.ReadLine();
            Console.Clear();
        }
    }
}
