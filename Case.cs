using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projettest
{
    class Case
    {
        public enum CaseType { Desert, Grotte, Temple, Boss, Foret };

        public int X;
        public int Y;
        public CaseType Type;
        public Case(int x, int y, CaseType T)
        {
            X = x;
            Y = y;
            Type = T;
        }
    }
}
