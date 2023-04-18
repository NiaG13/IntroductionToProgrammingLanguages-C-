// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
    int height = ReadInt("an array height");
    int length = ReadInt("an array length");
    int[,] arr = FillArray(height, length);
    PrintArray(arr);
    AverageColumn(arr);
}

int ReadInt(string argument)
{
    int number;
    System.Console.WriteLine($"Enter {argument}: ");
    while(!int.TryParse(Console.ReadLine(), out number) || number < 1)
    {
        System.Console.WriteLine("It's not that");
    }
    return number;
}

int[,] FillArray(int height, int length)
{
    int[,] array = new int[height, length];
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

void AverageColumn(int[,] array)
{
    System.Console.Write("The arifmetic means of the array columns are equal: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum +=array[i,j];
            count++;
        }
        double average = Math.Round(sum / count, 3);
        System.Console.Write($"{average}  ");
    }
    System.Console.WriteLine();
}