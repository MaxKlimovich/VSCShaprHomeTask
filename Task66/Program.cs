
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int m = Numbers("Введите m: ");
int n = Numbers("Введите n: ");
int temp = m;
if (m > n) 
{
  m = n; 
  n = temp;
}
Sum(m, n, temp=0);
void Sum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {sum} ");
    return;
  }
    Sum(m, n - 1, sum);
}
int Numbers(string input) 
{
  Console.Write(input);
  int end = Convert.ToInt32(Console.ReadLine());
  return end;
}