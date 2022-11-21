// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Enter any integer: ");
int a = int.Parse(Console.ReadLine());
a = Math.Abs(a);

if (a < 100) 
{
    Console.WriteLine($"{a} -> no 3rd digit");
}
else
{
    while (a > 999)
    {
        a /= 10;
        //Console.WriteLine(a);
    }

    Console.WriteLine($"{a} -> {a % 10}");
}