// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
    int height = new Random().Next(2,7);
    int length = new Random().Next(2,7);
    int[,] arrFirst = FillArray(height, length);
    PrintArray(arrFirst, "First");
    int[,] arrSecond = FillArray(length, height);
    PrintArray(arrSecond, "Second");
    int[,] productArrays = ProductArrays(arrFirst, arrSecond);
    PrintArray(productArrays, "Result");
}

int ReadInt(string argument)
{
    int number;
    System.Console.WriteLine($"Enter {argument}: ");
    while(!int.TryParse(Console.ReadLine(), out number) || number < 0)
    {
        System.Console.WriteLine("it's not that");
    }
    return number;
}

int[,] FillArray(int height, int length)
{
    int[,] array = new int [height,length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,4);
        }
    }
    return array;
}

void PrintArray(int[,] array, string argument)
{
    System.Console.WriteLine($"{argument} array:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]}   ");
        }
        System.Console.WriteLine();
    }
}

int[,] ProductArrays (int[,] array1, int[,] array2)
{
    int[,] result;
    result = new int[array1.GetLength(0), array1.GetLength(0)];
    int lengthProduct = array1.GetLength(1);
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < lengthProduct; k++)
            {
                result[i,j] += array1[i,k] * array2[k,j];
            }
        }
    }
    return result;
}
