/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int x = new Random().Next(100, 1000);
Console.WriteLine($"Возьмем число {x}. Сейчас я покажу тебе вторую цифру этого числа (даже не спрашивай, зачем).");
int hundreds = x / 100;
int tens = (x - hundreds * 100) / 10;
Console.WriteLine ($"Это цифра........ {tens}! Не благодари:)");

