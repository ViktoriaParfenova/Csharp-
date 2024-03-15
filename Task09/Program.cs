// Напишите программу которая принимает на вход 2 числа  и проверяет является ли одно квадратом другого

Console.WriteLine("Введите 2 числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (Math.Pow(num1, 2) == num2 || Math.Pow(num2, 2) == num1 )
{
    Console.WriteLine(" да ");
}
else
{
    Console.WriteLine(" нет ");
}