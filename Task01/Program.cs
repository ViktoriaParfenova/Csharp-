﻿/*Напишите программу,которая на вход принимает два числа и проверяет,является ли первое число квадратом второго.


a = 25;b = 5 -> да

*/

Console.WriteLine("Введите 2 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    Console.WriteLine("является");
}
else
{
    Console.WriteLine("не является");
}


