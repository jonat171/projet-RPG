using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projettest
{
    class Program
    {
        public static string pseudo;
        static void Main(string[] args)
        {
            Menu.MainMenu();
            Console.WriteLine("Donnez un nom à votre Héros !");
            pseudo = Console.ReadLine();
            Hero Pseudo = new Hero(pseudo, 10, 70, 2, 200); //energy

            //Hero Pseudo2 = new Hero(pseudo, 4, 12);   //Classes à suivre
            //Hero Pseudo3 = new Hero(pseudo, 5, 9);

            //Menu.MainMenu();               //Affichage de la map
            //Map map = new Map(20, 40);
            //map.Affichage();

            Gobelin Gobelin_Eclaireur = new Gobelin("Gobelin_Eclaireur", 1, 5, 1);
            Gobelin Gobelin_Archer = new Gobelin("Gobelin_Archer ", 2, 8, 1);
            Gobelin Gobelin_Guerrier = new Gobelin("Gobelin_Guerrier", 3, 12, 1);
            Gobelin Chef_Gobelin = new Gobelin("Chef_Gobelin", 5, 15, 1);

            Loup Louveteau = new Loup("Louveteau", 7, 18, 1);
            Loup Loup = new Loup("Loup", 9, 19, 1);
            Loup Chef_de_la_Meute = new Loup("Chef_de_la_Meute", 10, 20, 1);

            Ours Ours = new Ours("Ours", 20, 30, 2);

            Chimere Chimere_Passive = new Chimere("Chimere_Passive", 15, 50, 2);
            Chimere Chimere_Agressive = new Chimere("Chimere_Agressive", 15, 50, 2);

            Scorpion Scorpion_Empereur = new Scorpion("Scorpion_Empereur", 20, 60, 2);

            Ver_Des_Sables Ver_Des_Sables = new Ver_Des_Sables("Ver_Des_Sables", 30, 80, 3);

            Singe Le_Roi_Singe = new Singe("Le_Roi_Singe", 40, 125, 4 );

            Frere Ton_Frere = new Frere("Ton_Frere", 70, 400, 10);

            Histoire.Commencement();
            Histoire.Voyage1();
            int i = 0;
            while (i < 4)
            {
                Battle.WithGobelin(Pseudo, Gobelin_Eclaireur);
                i = i + 1;
                Battle.WithGobelin(Pseudo, Gobelin_Archer);
                i = i + 1;
                Battle.WithGobelin(Pseudo, Gobelin_Guerrier);
                i = i + 1;
                Battle.WithGobelin(Pseudo, Chef_Gobelin);
                i = i + 1;
            }

            Pseudo.LevelUp();
            Histoire.Voyage2();
            i = 0;
            while (i < 3)
            { 
                Battle.WithLoup(Pseudo, Louveteau);
                i = i + 1;
                Battle.WithLoup(Pseudo, Loup);
                i = i + 1;
                Battle.WithLoup(Pseudo, Chef_de_la_Meute);
                i = i + 1;
            }
            Pseudo.LevelUp();
            Histoire.Voyage3();
            Battle.WithOurs(Pseudo, Ours);

            Pseudo.LevelUp();
            Histoire.Voyage4();
            i = 0;
            while (i < 2)
            {
                Battle.WithChimere(Pseudo, Chimere_Passive);
                i = i + 1;
                Battle.WithChimere(Pseudo, Chimere_Agressive);
                i = i + 1;
            }
            Pseudo.LevelUp();
            Histoire.Voyage5();
            Battle.WithScorpion(Pseudo, Scorpion_Empereur);
            Pseudo.LevelUp();
            Histoire.Voyage6();
            Battle.WithVer_Des_Sables(Pseudo, Ver_Des_Sables);
            Pseudo.LevelUp();
            Histoire.Voyage7();
            Battle.WithSinge(Pseudo, Le_Roi_Singe);
            Pseudo.Divin();
            Histoire.Voyage8();
            Battle.WithFrere(Pseudo, Ton_Frere);
            

            Histoire.Fin();
        }
    }
    
}
