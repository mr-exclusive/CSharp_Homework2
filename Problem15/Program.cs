// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Enter day of the week (1 <= day <= 7): ");
int a = int.Parse(Console.ReadLine());

if (a == 6 || a == 7) 
{
    Console.WriteLine($"{a} -> Yes! It's a weekend.");
}
else if (a >= 1 && a < 6)
{
    Console.WriteLine($"{a} -> No, it's a workday.");
}
else
{
    Console.WriteLine($"{a} -> Invalid input");
}