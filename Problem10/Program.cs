// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

var rnd = new Random();
int randNumber = rnd.Next(100, 999); 

Console.WriteLine($"{randNumber} -> {randNumber.ToString()[1]}");
