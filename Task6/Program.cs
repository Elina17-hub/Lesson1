// Комментарий
/*
    Это многострочный
     комментарий
*/
// CMD+?/
// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// тип_данных  имяПеременной = значение
// camelCase: firstNumber, secondNumber
// Convert.ToInt32("123") => 123 +200 = 323
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
// firstNumber = 25, secondNumber = 5
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

// "==" - проверка условий, "=": int a = 5;
if (firstNumber == secondNumber * secondNumber)
// Является ли первое число квадратом второго?
{
    Console.WriteLine("Да, " + firstNumber + " является квадратом secondNumber " + secondNumber);
}