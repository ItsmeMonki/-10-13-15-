//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int n1 = num / 10;
int n2 = num % 10;

int result = n2 = n1 % 10;

Console.WriteLine($"{result} -> Второе число");