//Задача 2: Напишите программу, которая на вход принимает два числа и 
//выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
int firstNumber, secondNumber, minNumber, maxNumber;
Console.WriteLine("Enter the first number: ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
secondNumber = Convert.ToInt32(Console.ReadLine());
maxNumber = firstNumber > secondNumber ? firstNumber : secondNumber;
minNumber = firstNumber < secondNumber ? firstNumber : secondNumber;
Console.WriteLine($"The maximum number is: {maxNumber}.");
Console.WriteLine($"The mininimum number is: {minNumber}.");