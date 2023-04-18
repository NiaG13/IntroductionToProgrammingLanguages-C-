// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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
    int m = ReadInt("an array height");
    int n = ReadInt("an array length");
    double[,] arr = FillArray(m, n);
    System.Console.WriteLine("Array:");
    PrintArray(arr);
    System.Console.WriteLine();
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

double[,] FillArray(int height, int length)
{
    double[,] array = new double[height, length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(new Random().NextDouble() *(-10 - 10) + 10, 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"({array[i,j]})   ");
        }
        System.Console.WriteLine();
    }
}