//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int size = ReadInt("Введите размерность массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers,0,15);;
WriteArray(numbers);

int max = numbers[0];
int min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {max - min}");


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

int ReadInt(string message)  
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}