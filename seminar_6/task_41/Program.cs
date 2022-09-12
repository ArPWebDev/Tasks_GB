/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int numPos(int count) {
    int result = 0;
    for (int i = 1; i <= count; i++)
    {
        Console.Write($"Введите {i} число: ");
        int j = Convert.ToInt32(Console.ReadLine());
        if (j > 0) result++;
    }
    return result;
}

Console.Write("Введите количество чисел");
int countNum = Convert.ToInt32(Console.ReadLine());
int resultNumPos = numPos(countNum);
Console.WriteLine($"{resultNumPos} числа(ел) больше нуля");