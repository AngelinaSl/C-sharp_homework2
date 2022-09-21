/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число: "); // 79473
int x = Convert.ToInt32(Console.ReadLine());
int w = 0;
if (x < 100)
{
    Console.WriteLine("Здесь нет 3го числа");
}
else if (x >=100 && x <=999)
{
    int y = x % 10;
    Console.WriteLine(y);
}
else if (x > 999)
{
   while ( x > 999)
    {
        x = x / 10;
    }
    int y = x % 10;
    Console.WriteLine(y);
}
