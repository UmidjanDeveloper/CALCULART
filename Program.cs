﻿using System;
System.Console.WriteLine("Type 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Type 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"1st Number is grater than 2nd number: {firstNumber > secondNumber}");
System.Console.WriteLine($"1st Num equal to 2nd Num: {firstNumber == secondNumber}");
System.Console.WriteLine($"1st Num not equal to 2nd Num: {firstNumber != secondNumber}");
System.Console.WriteLine($"1st Num less than or equal to 2nd Num: {firstNumber <= secondNumber}");
System.Console.WriteLine($"1st Num greater than or equal to 2nd Num: {firstNumber >= secondNumber}");