﻿//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
//[3, 7, 23, 12] => 19
//[-4, -6, 89, 6] => 0

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [size];
int sum=0;

FillArrayRandomNumbers(numbers,0,10);
WriteArray(numbers);

for (int i = 0; i< numbers.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum=sum+numbers[i];
        }
                  
    }
 Console.Write($"Сумма чисел на нечетных позициях {sum}");

void FillArrayRandomNumbers (int[] array, int min, int max)
{
    for (int i = 0; i< array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    }

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i]+" ");
    }
    Console.WriteLine();
    }

