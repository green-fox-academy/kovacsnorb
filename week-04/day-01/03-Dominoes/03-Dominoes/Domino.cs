using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Dominoes
{
    class Domino
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }
    }
}
