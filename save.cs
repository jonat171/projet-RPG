using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projettest
{
    public class Class1

    {

        public static void SaveGame(Person.Person t)
        {

            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            using (StreamWriter s = new StreamWriter(mydocpath + @"/save.txt"))
            {

                s.WriteLine(t.name + ";" + t.attack + ";" + t.health + ";" + t.armor);
            }


            Console.Write("Press Enter to Quit ...");
            Console.ReadLine();
            Environment.Exit(0);
        }

        public void LoadGame()
        {

            string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/save.txt";


            try
            {
                using (StreamReader r = new StreamReader(Path))
                {

                }
            }
            catch
            {

            }
        }

    }
}

