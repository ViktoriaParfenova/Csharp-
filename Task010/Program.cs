//  Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите числo: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (N > 0)
{
 count = N % 10;
 N = N / 10;
 System.Console.Write(count + ",");
 
}
