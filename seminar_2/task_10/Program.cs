// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());

if (99 < number && number < 1000)
{
    int second = number / 10 % 10;
    Console.WriteLine($"Вторая цифра указанного числа{second}");
}
else Console.WriteLine("Введено не трёхзначное число");