 
 /* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 14212 -> нет
 23432 -> да
 12821 -> да */

Console.Write("Введите пятизначное число");

string numStr = Console.ReadLine();

if (numStr.Length != 5) Console.WriteLine("Введено не пятизначное число");
else
{   
    int numInt = Convert.ToInt32(numStr);
    if ((numInt / 10000 == numInt % 10) && ((numInt / 1000 % 10 == numInt / 10 % 10)))
    {
        Console.WriteLine("Число не палиндромом");
    }
    else Console.WriteLine("Число палиндромом");
}
