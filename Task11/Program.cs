/* Напишите программу,которая принимает на вход координаты точки (x и y),причем X≠0  и Y ≠0 и выдает номер координатной 
четверти плоскости,в которой находится эта точка.
*/

Console.Write("Введите координаты точки x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("номер координатной четверти плоскости 1");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("номер координатной четверти плоскости 2");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("номер координатной четверти плоскости 3");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("номер координатной четверти плоскости 4");
}
else
{
    Console.WriteLine("значения x и y не должны равняться 0");
}
