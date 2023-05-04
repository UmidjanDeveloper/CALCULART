using System;
using CalculatR.Classes;
namespace CalculatR
{

internal class Program
{
    private static void Main(string[] args)
    {
        Security security = new Security();
        Calculator calculator = new Calculator();

        security.CheckPassword();
        calculator.GetInputs();
      

        string message =
            calculator.IsFirstNumberPositive()
                ? "First number is positive"
                : "First number is negative";
        Console.WriteLine(message);
        string message2 = 
            calculator.IsSecondNumberPositive()
                ? "Second number is positive"
                : "Second number is negative";
        Console.WriteLine(message2);

         calculator.CompareInputs();

        string result = calculator.Calculate();
        System.Console.WriteLine(result);
        calculator.PrintEvenNumbers();
        calculator.PrintMultiplicationTable();
    }
}
}