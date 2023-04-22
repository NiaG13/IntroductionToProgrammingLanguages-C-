// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Main();

void Main()
{
    bool work = true;
    while(work)
    {
        System.Console.WriteLine("Hello! Run the program? y/n");
        string a = Console.ReadLine();
        switch(a)
        {
            case "y": Task(); break;
            case "n": work = false; break;
            default: break;
        }
    }
    System.Console.WriteLine("Have a good time!");
}

void Task()
{
    int length = new Random().Next(2,6);
    int[,] arr = FillArray(length, length);
    PrintArray(arr);
    int lineMinSum = FindLineMinSum(arr);
    System.Console.WriteLine($"Minimum sum on the line {lineMinSum}.");
}

int[,] FillArray(int height, int length)
{
    int[,] array = new int [height,length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    System.Console.WriteLine("Array:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}   ");
        }
        System.Console.WriteLine();
    }
}

int FindLineMinSum(int[,] array)
{
    int line = 1;
    int minSumLine = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minSumLine += array[0,j];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if(sum < minSumLine)
        {
            minSumLine = sum;
            line = i + 1;
        }
    }
    return line;
}