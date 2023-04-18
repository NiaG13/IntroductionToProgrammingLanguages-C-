// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
    PrintArray(arr);
    int indexLine = ReadInt("a line number");
    int indexColumn = ReadInt("a column number");
    FindElement(arr, indexLine, indexColumn);
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
            array[i,j] = new Random().Next(-10,11);
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

void FindElement(int[,] array, int indexLine, int indexColumn)
{
    if (indexLine <= array.GetLength(0)-1 && indexColumn <= array.GetLength(1)-1)
    {
        System.Console.WriteLine($"The element value is {array[indexLine,indexColumn]}.");
    }
    else System.Console.WriteLine("The element doesn't exist.");
}