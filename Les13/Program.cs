//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int n1 = num / 10;
int n2 = num % 10;
int n3 = num % 10;
int result = n3 = n2 % 10;

Console.WriteLine($"{result} -> Третье число");
