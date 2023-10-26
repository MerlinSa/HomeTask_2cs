//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine("I коорд.четверть");
}
if(x < 0 && y < 0)
{
    Console.WriteLine("III коорд.четверть");
}
if(x > 0 && y < 0)
{
    Console.WriteLine("IV коорд.четверть");
}
if(x < 0 && y > 0)
{
    Console.WriteLine("II коорд.четверть");
}
