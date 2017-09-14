using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations:
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit

            Console.WriteLine("Please type in the expression, in this format: {operation} {operand} {operand}, for example: + 30 4");
            //string userInput = Console.ReadLine();
            string[] userInputSplitted = Console.ReadLine().Split(' ');
            Console.WriteLine(CalculateMe(userInputSplitted[0], userInputSplitted[1], userInputSplitted[2]));
            Console.ReadLine();
        }

        public static int CalculateMe(string operation, string operand1, string operand2)
        {
            int convertedOperand1 = int.Parse(operand1);
            int convertedOperand2 = int.Parse(operand2);
            int output = 0;

            switch (operation)
            {
                case "+":
                    output = convertedOperand1 + convertedOperand2;
                    break;
                case "-":
                    output = convertedOperand1 - convertedOperand2;
                    break;
                case "*":
                    output = convertedOperand1 * convertedOperand2;
                    break;
                case "/":
                    output = convertedOperand1 / convertedOperand2;
                    break;
                case "%":
                    output = convertedOperand1 % convertedOperand2;
                    break;
                default:
                    break;
            }

            return output;
        }
    }
}
