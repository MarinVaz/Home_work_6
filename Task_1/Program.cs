//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [size];
int k=0;

FillArrayRandomNumbers(numbers,100,1000);
WriteArray(numbers);

for (int i = 0; i< numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {k++;}
                  
    }
 Console.Write($"Количество четных чисел {k}");

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

