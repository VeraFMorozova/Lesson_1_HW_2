// Задача 4
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Напишите первое число");
int firstnumber = int.Parse(Console.ReadLine());
Console.Write("Напишите второе число");
int secondnumber = int.Parse(Console.ReadLine());
Console.Write("Напишите третье число");
int thirdnumber = int.Parse(Console.ReadLine());
int max = firstnumber;

if (firstnumber > max) max = firstnumber;
if (secondnumber > max) max = secondnumber;
if (thirdnumber > max) max = thirdnumber;

Console.WriteLine ($"max = {max}");