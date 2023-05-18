// Задача 7: Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает последнюю цифру
//этого числа.
//456 -> 6
//782 -> 2
//918 -> 8
Console.WriteLine("Enter any nomber: ");
int yourNumber = Convert.ToInt32(Console.ReadLine());
yourNumber = yourNumber % 10;
Console.WriteLine(yourNumber);