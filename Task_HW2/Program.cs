// // Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine("Данное число делиться на 7 и на 23");
// }
// else
// {
//     Console.WriteLine("Данное число не делиться на 7 и 23");
// }

// /
// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Console.Write("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // Проверим, что число входит в данный диапазон
// if (number >= 10 && number <= 99)
// {
//     int firstDigit = number / 10;
//     int secondDigit = number % 10;
//     int maxDigit = Math.Max(firstDigit, secondDigit);
//     Console.WriteLine($"наибольшая цифра числа {number} : {maxDigit}");
// }
// else
// {
//     Console.WriteLine("Введенное число не попадает в данный диапазон");
// }


// //Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

//  Console.WriteLine("Ввведите значение X: ");
//  int x = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Ввведите значение Y: ");
//  int y = Convert.ToInt32(Console.ReadLine());
//  if (x > 0 && y > 0)
//  {
//     Console.WriteLine("Точка находиться в первой четверти координат");
//  }
//  else if (x < 0 && y > 0)
//  {
//     Console.WriteLine("Точка находиться во второй четверти координат");
//  }
//  else if (x < 0 && y < 0)
//  {
//     Console.WriteLine("Точка находиться в третьей четверти координат");
//  }
//  else if (x > 0 && y < 0)
//  {
//     Console.WriteLine("Точка находиться в четвертой четверти координат");
//  }


//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую
  Console.WriteLine("введите натуральное число N: ")
  int number = Convert.ToInt32(Console.ReadLine);
  if (number < 0) 
  {
    Console.WriteLine("Число не натуральное");
  } 
  else
  {
    int firstDigit = number / 10 % 10 // узнаем сколько в числе десятков
  }





   