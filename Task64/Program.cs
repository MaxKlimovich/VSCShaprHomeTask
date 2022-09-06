

//Задача 64
//Задайте значение M и N.
//Напишите программу, которая выведет все натуральне числа в промежутке от N до 1.
//С помощью рекурсии.

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNum(int num)
{
    if (num == 0) return;
    NaturalNum(num - 1);
    Console.Write($"{num}");

}

NaturalNum(number);