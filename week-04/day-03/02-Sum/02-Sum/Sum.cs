using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Sum
{
    public class Sum
    {
        public int SumOfRecords(List<int> inputList)
        {
            int sumOfElements = 0;

            if (inputList != null)
            {
                foreach (int element in inputList)
                {
                    sumOfElements += element;
                }
            }
            
            return sumOfElements;
        }
    }
}
