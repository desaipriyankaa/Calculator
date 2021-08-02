using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("***** CALCULATOR *****");
            Console.WriteLine("Addition is :"+Calculation.Add(2,3));
            Console.WriteLine("Subtraction is :" + Calculation.Substract(3, 1));
            Console.WriteLine("Multiplication is :" + Calculation.Multiply(2, 3));
            Console.WriteLine("Division is :" + Calculation.Divide(10, 5));
        }
    }
}
