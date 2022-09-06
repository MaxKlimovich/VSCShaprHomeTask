

// следующая задача №60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Задача №60");
Console.WriteLine("----------------------------------------");

void FillArray(int[,,] array, int rows, int columns, int pageCount)
{
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < pageCount; k++)
            {
                array[i, j, k] = rnd.Next(10, 100);
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число страниц массива: ");
int pageCount = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[rows, columns, pageCount];

Console.WriteLine();
Console.WriteLine("Массив: ");
FillArray(array, rows, columns, pageCount);