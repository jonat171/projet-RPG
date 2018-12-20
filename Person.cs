using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projettest
{
    public class Person
    {

        public string name;
        public int attack;
        public int health;
        public int armor;
        public int MaxEnergy = 200;   

        public Person(string _name, int _attack, int _health, int _armor)
        {
            name = _name;
            attack = _attack;
            health = _health;
            armor = _armor;

        }

        public void PrintStats()
        {
            Console.WriteLine("{0} stats:", name);
            Console.WriteLine("");
            Console.WriteLine("Attaque: {0}", attack);
            Console.WriteLine("Point de Vie: {0}", health);
            Console.WriteLine("armor: {0}", armor);
            Console.WriteLine("energie: {0}", MaxEnergy);
        }

        public void NormAttack(Person target)
        {
            
            target.health -= attack -target.armor;
        }
    }
}

