// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
    int height = new Random().Next(3,10);
    int length = new Random().Next(3,10);
    int[,] arr = FillArray(height, length);
    PrintArray(arr, "Sourse");
    arr = SortingLineArray(arr);
    PrintArray(arr, "Sorting lines of the");
}

int[,] FillArray(int height, int length)
{
    int[,] array = new int [height,length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-10,11);
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

int[,] SortingLineArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1)-1; j > 0; j--)
        {
            for (int k = j - 1; k >= 0; k--)
            {
                if(array[i,k] > array[i,j])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
    return array;
}
