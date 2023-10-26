//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

Console.WriteLine("Введите двухзначное число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x >= 10 && x <= 99)
{
    int a = x / 10;
    int b = x % 10;
    if (a > b)
    {
        Console.Write(a + " is max");
    }
    else{
        Console.Write(b + " is max");
    }
}
else
{
    Console.WriteLine("Введенное число вне отрезка");
}
