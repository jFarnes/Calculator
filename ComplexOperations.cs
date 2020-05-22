using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class ComplexOperations : SimpleOperations
    {
        public ComplexOperations()
        {
            Boolean flag = true;
            int userInput;

            while (flag)
            {
                Console.Clear();
                Console.WriteLine("Complex matemathical operations");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Menu");
                Console.WriteLine("1.Sen and Cos functions");
                Console.WriteLine("2.Elevate a number");
                Console.WriteLine("3. Substract 2 numbers");
                Console.WriteLine("4. Divide 2 numbers");
                Console.WriteLine("5. Multiply 2 numbers");
                Console.WriteLine("0. Back to simple operations");

                Console.WriteLine("Select an Option:");
                userInput = Int32.Parse(Console.ReadLine());

                if (userInput == 0)
                {
                    flag = false;
                }
            }
        }
    }
}
