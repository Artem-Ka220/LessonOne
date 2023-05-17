//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
int max;
Console.WriteLine("Enter the first number.");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number.");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the third number.");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

max = firstNumber > secondNumber ? firstNumber : secondNumber;
max = max > thirdNumber ? max : thirdNumber;

Console.WriteLine($"Maximum number: {max}.");