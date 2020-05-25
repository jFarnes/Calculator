using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Calculator
{
    class Calculator
    {
        public static void complexOperationsMenu() { 
            ComplexOperations complexOperateMe = new ComplexOperations();
            int userSelection, numberOne, numberTwo;
            Console.Clear();
            Console.WriteLine("Complex matemathical operations");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Menu");
            Console.WriteLine("1. Sen and Cos function");
            Console.WriteLine("2. ");
            Console.WriteLine("3. Elevate n x m");
            Console.WriteLine("4. Squareroot");
            Console.WriteLine("5. Back to simple operations");
            Console.WriteLine("0. Exit");

            Console.WriteLine("Select an Option:");
            userSelection = Int32.Parse(Console.ReadLine());
           
            if (userSelection == 0)
            {
                System.Environment.Exit(0);
            }
            else if (userSelection == 5)
                simpleOperationsMenu();

            switch (userSelection)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Enter an angle.");
                    numberOne = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("The cos result in degrees for your angle " + numberOne + " is: " + (Math.Cos((Math.PI * numberOne) / 180)));
                    Console.WriteLine("The sen result in degrees for your angle " + numberOne + " is: " + Math.Sin(((Math.PI * numberOne) / 180)));
                    Console.ReadLine();
                    break;
                case 2:
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Input n number:");
                    numberOne = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Enter elevation potency m");
                    numberTwo = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Your elevater number is: " + Math.Pow(numberOne, numberTwo));
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Input numer one to calculate the squareroot:");
                    numberOne = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("The squareroot of your number is: " + Math.Sqrt(numberOne));
                    Console.ReadLine();
                    break;
            }
            complexOperationsMenu(); 
        }

        public static void simpleOperationsMenu()
        {
            SimpleOperations simpleOperateMe = new SimpleOperations();
            int userSelection, numberOne, numberTwo;

            Console.Clear();
            Console.WriteLine("Simple matemathical operations");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add 2 numbers");
            Console.WriteLine("2. Substract 2 numbers");
            Console.WriteLine("3. Divide 2 numbers");
            Console.WriteLine("4. Multiply 2 numbers");
            Console.WriteLine("5. Swtich to complex operations");
            Console.WriteLine("0. Exit");

            Console.WriteLine("Select an Option:");
            userSelection = Int32.Parse(Console.ReadLine());

            if (userSelection == 0)
            {
                System.Environment.Exit(0);
            }
            else if (userSelection == 5)
            {
                complexOperationsMenu();
            }

            Console.WriteLine("Input numer one:");
            numberOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input numer two:");
            numberTwo = Int32.Parse(Console.ReadLine());

            switch (userSelection)
            {
                case 1:
                    Console.WriteLine("Your result: " + simpleOperateMe.addition(numberOne, numberTwo));
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Your result: " + simpleOperateMe.substraction(numberOne, numberTwo));
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Your result: " + simpleOperateMe.division(numberOne, numberTwo));
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Your result: " + simpleOperateMe.multiplication(numberOne, numberTwo));
                    Console.ReadLine();
                    break;
            }
            simpleOperationsMenu();
        }

        static void Main(string[] args)
        {
            while(true)
            simpleOperationsMenu();
        }
    }
}
