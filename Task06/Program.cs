﻿/* Напишите программу которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
*/

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int dig1 = number / 100;
int dig3 = number % 10;
Console.WriteLine(dig1*10 + dig3);