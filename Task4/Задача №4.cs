﻿/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2 3 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write( "Введите первое число  ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write( "Введите второе число  ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write( "Введите третье число  ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine("Максимальным числом является : " + numberA);
}
else 
{
    Console.WriteLine("Максимальным числом является : " + numberC);
}
if  (numberB > numberC)
{
    Console.WriteLine("Максимальным числом является : " + numberB);
}