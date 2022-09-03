//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int n = num;
int count = 0;

while (n != 0){ //поиск общего количества знаков
    n = n/10;
    count++;
}
int remDiv = 1; //вычисление, от какого числа надо искать остаток деления
for (int i = 2; i < count; i++){
    remDiv *= 10;
}
int div = 1; //переменная для деления и отбрасывания лишних цифр справа

if (count < 3){
    Console.WriteLine("Третьей цифры нет");
} else {
    while(count > 3){
        div *= 10;
        count--;
    }
    int n1 = (num % remDiv)/div;
    Console.WriteLine(n1);
}