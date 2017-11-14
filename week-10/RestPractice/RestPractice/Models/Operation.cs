using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestPractice.Models
{
    public class Operation
    {
        [JsonIgnore]
        public string what;
        [JsonIgnore]
        public int[] numbers;
        public string result;

        public Operation(OperationObj inputObject)
        {
            
            what = inputObject.what;
            numbers = inputObject.numbers;

            if (what == "sum")
            {
                int sumOfNumbers = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    sumOfNumbers += numbers[i];
                }
                result = sumOfNumbers.ToString();
            }
            else if (what == "multiply")
            {
                int multiplyOfNumbers = 1;

                for (int i = 0; i < numbers.Length; i++)
                {
                    multiplyOfNumbers *= numbers[i];
                }
                result = multiplyOfNumbers.ToString();
            }
            else if (what == "double")
            {
                result = "[";
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    result += 2 * numbers[i];
                    result += ", ";
                }
                result += 2 * numbers.Last();
                result += "]";
            }
        }
    }
}
