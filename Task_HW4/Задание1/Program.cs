//Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
while (true)
{
    Console.WriteLine("Введите целое число (или 'q' для выхода):");
    string text = Console.ReadLine();
    if (text == "q")
    {
        Console.WriteLine("Программа завершена.");
        break;
    }
    if (int.TryParse(text, out int number))
    {

        int sum = 0;
        while (number > 0)
        {

            {
                sum = sum + number % 10;
                number = number / 10;
            }
        }
        if (sum % 2 == 0)
        {
            Console.WriteLine($"Сумма цифр введенного числа четная. Программа завершена.");
            break;
        }
    }
}

