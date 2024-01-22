
//Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
Random random = new Random();//Создание объекта для ген. случайных чисел
int[] array = new int[5]; // произвольный массив из 5ти шт. трехзначных чисел
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000); //заполняем массив случайными трехзначными числами
    Console.Write(array[i] + ";");
}
int countEven = 0;
foreach (int num in array)
{
    if (num % 2 == 0)// проверяем на четность
    {
        countEven++;
    }
    Console.WriteLine("\n Количество четных чисел в массиве:" + countEven);

}

