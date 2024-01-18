// // 

// //задача с 5 гирями и какая самая тяжелая

// int n = 5;
// int[] array = { 2, 50, 45, 3, 99 };
// int i = 0;
// int max = array[0];
// while (i < n)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     i = i + 1;
// }
// Console.WriteLine(max);

// // тоже самое с for
// max = array[0];
// for (int j = 0; j < n; j++)
// {
//     if (array[j] > max)
//     {
//         max = array[j];
//     }
// }
// Console.WriteLine(max);

// //тоже самое с Foreach

// max = array[0];
// foreach (int e in array)
// {
//     if (e > max)
//     {
//         max = e;
//     }
// }
// Console.WriteLine(max);

// задача, обнулить четные значения в массиве
void ZeroEvenElements(int[] arr)
{
    //переберем все элементы массива через цикл for
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}
int[] array= { 1, 5, 4, 8, 6, 10 };
ZeroEvenElements(array);
PrintArray(array);