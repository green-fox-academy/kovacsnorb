using System;
using System.Collections.Generic;

namespace _06_Extension
{
    public class Extension
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int MaxOfThree(int a, int b, int c)
        {
            if (a > b && a > c)
                return a;
            else if (b > a && b > c)
                return b;
            else
                return c;
        }

        public float Median(List<int> pool)
        {
            pool.Sort();

            if (pool.Count % 2 == 1)
            {
                return pool[(pool.Count - 1) / 2];
            }
            else
            {
                return (pool[(pool.Count - 1) / 2] + pool[(pool.Count + 1) / 2]) / 2;
            }
        }

        public bool IsVowel(char c)
        {
            return (new List<char>() { 'a', 'u', 'o', 'e', 'i', 'A', 'U', 'O', 'E', 'I' }).Contains(c);
        }

        public string Translate(string hungarian)
        {
            string teve = hungarian;
            int length = teve.Length;
            List<char> vowels = new List<char>();
            for (int i = 0; i < length; i++)
            {
                char c = teve[i];
                if (IsVowel(c) && !vowels.Contains(c))
                {
                    vowels.Add(c);
                    teve = string.Join(c + "v" + c, teve.Split(c));
                    i += 2;
                    length = teve.Length;
                }
            }
            return teve;
        }
    }
}

