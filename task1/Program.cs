// Задача 1: Напишите программу, которая принимает на вход число 
//и проверяет, кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine(a + " кратно 7 и 23");
}
else{
    Console.WriteLine(a + " не кратно 7 и 23");
}
