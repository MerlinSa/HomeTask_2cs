//Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите натур.число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(String.Join(",", Enumerable.Range(1, n)));
Console.ReadLine();