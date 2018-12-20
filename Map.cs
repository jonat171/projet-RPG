using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projettest
{
    class Map
    {
        public int Largeur;
        public int Longueur;
        public Case[,] Plateau;

        public Map(int L, int l)
        {
            Largeur = L;
            Longueur = l;
            Plateau = new Case[Largeur, Longueur];

            for (int i = 0; i < Largeur; i++)
            {
                for (int j = 0; j < Longueur; j++)
                {
                    Plateau[i, j] = new Case(i, j, Case.CaseType.Foret);
                }
            }
        }

        public void Affichage()
        {
            for (int i = 0; i < Largeur; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Longueur; j++)
                {
                    Console.Write("0");
                }
            }
        }
    }
}
