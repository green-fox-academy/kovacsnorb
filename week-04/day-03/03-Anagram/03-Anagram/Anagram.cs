using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Anagram
{
    public class Anagram
    {
        public bool IsAnagram(string input1, string input2)
        {
            bool isAnagram = false;
            char[] input1Array = input1.ToCharArray();
            char[] input2Array = input2.ToCharArray();

            Array.Sort(input1Array);
            Array.Sort(input2Array);

            if (input1.Length != input2.Length)
            {
                return isAnagram;
            }
            else
            {
                int counter = 0;
                for (int i = 0; i < input1Array.Length; i++)
                {
                    if (input1Array[i] != input2Array[i])
                    {
                        counter++;
                    }
                }

                if (counter == 0)
                {
                    return isAnagram = true;
                }
                else
                {
                    return isAnagram;
                }
            }
        }
    }
}
