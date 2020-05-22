using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            SimpleOperations operateMe = new SimpleOperations();
            Boolean flag = true;
            int userSelection, numberOne, numberTwo;
            int sOutput;

            while (flag)
            {
                Console.Clear();
                Console.WriteLine("Simple matemathical operations");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Menu");
                Console.WriteLine("Simple matemathical operations");
                Console.WriteLine("1. Add 2 numbers");
                Console.WriteLine("2. Substract 2 numbers");
                Console.WriteLine("3. Divide 2 numbers");
                Console.WriteLine("4. Multiply 2 numbers");
                Console.WriteLine("5. Swtich to complex operations");
                Console.WriteLine("0. Exit");

                Console.WriteLine("Select an Option:");
                userSelection = Int32.Parse(Console.ReadLine());

                if (userSelection == 0)
                    break;

                Console.WriteLine("Input numer one:");
                numberOne = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Input numer two:");
                numberTwo = Int32.Parse(Console.ReadLine());


                switch (userSelection)
                {
                    case 1:
                        sOutput = operateMe.addition(numberOne,numberTwo);
                        Console.WriteLine("The addition of your 2 numbers is: " + sOutput);
                        Console.ReadLine();
                        break;
                    case 2:
                        sOutput = operateMe.substraction(numberOne, numberTwo);
                        Console.WriteLine("The substracion of your 2 numbers is: " + sOutput);
                        Console.ReadLine();
                        break;
                    case 3:
                        sOutput = operateMe.division(numberOne, numberTwo);
                        Console.WriteLine("The division of your 2 numbers is:" + sOutput);
                        Console.ReadLine();
                        break;
                    case 4:
                        sOutput = operateMe.multiplication(numberOne, numberTwo);
                        Console.WriteLine("The multiplicaion of your 2 numbers is: " + sOutput);
                        Console.ReadLine();
                        break;
                    case 5:
                        ComplexOperations cOperations = new ComplexOperations();
                        break;
                    default:
                        Console.WriteLine("Option out of bounds, please try again.");
                        break;
                }
            }
        }
    }
}
