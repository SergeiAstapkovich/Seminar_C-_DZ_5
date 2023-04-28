/* Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine()!);
int[] Array = GetArray(length, min, max);
Console.WriteLine($"[{string.Join(", ", Array)}]"); // преобразования целочисленного массива в строку
FindEven(Array);

int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd= new Random(); // переменная генератор случайных чисел
    int[] result= new int[size];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void FindEven(int[] MyArray)
{
    int even = 0;
    for (int i = 0; i < MyArray.Length; i++)
    {
        if(MyArray[i]%2==0) // проверка четного
        {
            even++;
        }
    }
    Console.WriteLine($"Чётных чисел {even}");
}