﻿// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 167 => 1+7

Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
// [100 , 999]
// "&&" оператор "И" : яблоки И апельсины
if (number >=100 && number <= 999)
{
    Console.WriteLine("Число трехзначное :)");
    // 167 => 1 + 7. 1. Делим на 10 с  остатком равен 7, это третья цифра/ Первая цифра - делим на 100 и берем целое число -1
    int thirdDigit = number % 10; // 167 % 10 = 7
    int firstDigit = number / 100; // 167 / 100 = 1
    int result = firstDigit + thirdDigit;
    Console.WriteLine("Сумма 1 и 3 цифры от числа: " + number + " = " + result);
}
else
{
    Console.WriteLine("Число  НЕ трехзначное :)");
}
