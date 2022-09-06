
//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка


int[,] GetMatrix(int n, int m)
{
    int[,] matrix = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindMinSumElementLineMatrix(int[,] matrix)
{
    int tempSum = 0;
    int sum = 0;
    int tempLine = 0;
    int line = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        tempSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tempSum += matrix[i, j];
            tempLine = i;
        }
        sum = tempSum;
        line = tempLine;
        Console.WriteLine($"Cумма эелемнтов находится в {line + 1} строке и равна: {sum} ");

    }


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        tempSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tempSum += matrix[i, j];
            tempLine = i;
        }
        if (sum > tempSum)
        {
            sum = tempSum;
            line = tempLine;
        }
    }
    Console.WriteLine();
    Console.Write($"Минимальная сумма эелемнтов находится в {line + 1} строке и равна: {sum} ");
}



int[,] matrix = GetMatrix(4, 4);
PrintMatrix(matrix);
Console.WriteLine();
FindMinSumElementLineMatrix(matrix);