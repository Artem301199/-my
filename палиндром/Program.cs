﻿//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine(" Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
if( a/10000 == a%10 & a/1000%10 == a%100/10)
{
    Console.WriteLine( " да");
}
else
{
    Console.WriteLine( " no");
}