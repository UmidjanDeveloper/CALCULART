using System;
System.Console.WriteLine("Type 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
//Switch operator
System.Console.WriteLine("Enter any operation that you want to proccess with (-,+,*,/,%):   ");
string operation = Console.ReadLine();
System.Console.WriteLine("Type 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
//Ternary Operator
string message = (firstNumber >= 0)
        ? "First number is positive"
        : "First number is negative";
System.Console.WriteLine(message);

if (firstNumber > secondNumber)
{
    System.Console.WriteLine("1st number is greater than 2nd number");
}
else if (firstNumber == secondNumber)
{
    System.Console.WriteLine("1st number equal to 2nd number");
}
else
{
    System.Console.WriteLine("1st number less than or equal to 2nd number");
}
// switch operations
string result = operation switch
{
        "+" => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
        "-" => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
        "/" => $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}",
        "*" => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
        "%" => $"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}",
        _ => "Operation not found!"
}; 
 System.Console.WriteLine(result); 
 // while loop
 int counter = 1;
while(counter < firstNumber)
{
    if(counter % 2 == 0)
    {
        System.Console.WriteLine(counter);
    }
    counter++;
}