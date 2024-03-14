/* Напишите программу,которая будет принимать  на вход два числа и выводить,являеется ли 
второе число кратно первому,если второе число не кратно первому то программа выводит остаток от деления

*/

Console.WriteLine("Введите 2 числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 ==0)
{
Console.WriteLine("кратно");
}
else 
{
Console.WriteLine("некратно" +num1 % num2);
}