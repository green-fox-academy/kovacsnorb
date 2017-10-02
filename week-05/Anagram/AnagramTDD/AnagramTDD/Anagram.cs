using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramTDD
{
    public class Anagram
    {

        public static bool IsAnagram(string input1, string input2)
        {

            input1 = input1.ToLower();
            input2 = input2.ToLower();

            char[] CharArray1 = input1.ToCharArray();
            List<char> list1 = CharArray1.ToList();
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] == ' ')
                {
                    list1.RemoveAt(i);
                }
            }
            list1.Sort();
            char[] CharArray2 = input2.ToCharArray();
            List<char> list2 = CharArray2.ToList();
            for (int i = 0; i < list2.Count; i++)
            {
                if (list2[i] == ' ')
                {
                    list2.RemoveAt(i);
                }
            }
            list2.Sort();

            if (list1.Count != list2.Count)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    if (list1[i] != list2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
