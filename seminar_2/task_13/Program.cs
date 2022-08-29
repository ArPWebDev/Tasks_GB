// Напишите программу, которая выводит третью цифру (слева направо) заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");   
long number = long.Parse(Console.ReadLine()); 

if (number > 99)
{
    long third = number / 100 % 10;
    Console.WriteLine($"Третья цифра {third}");
}
else Console.WriteLine("Третьей цифры нет");