using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Calculator
{
    public class SimpleOperations
    {
        internal int addition(int num1, int num2)
        {
            return num1 + num2;
        }

        internal int substraction(int num1, int num2)
        {
            return num1 - num2;
        }
        
        internal int multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        internal int division(int num1, int num2)
        {
            try
            {
                return num1/num2;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                return 0;
            }
        }
    }
}
