

//Задача 62. Заполните спирально массив 4 на 4. Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

int A = 4;
int[,] Massiv = new int[A, A];
int temp = 1;
int i = 0;
int j = 0;
while (temp <= Massiv.GetLength(0) * Massiv.GetLength(1))
{
  Massiv[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < Massiv.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= Massiv.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > Massiv.GetLength(1) - 1)
    j--;
  else
    i--;
}
Array(Massiv);
void Array (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");
      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}