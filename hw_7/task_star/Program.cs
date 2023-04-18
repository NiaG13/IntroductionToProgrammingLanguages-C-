// сортировка двумерного массива (в данном случае пузырьком по строкам и столбцам;
// вставками, слиянием, быстрая сортировка - почитал, очень интересно было бы реализовать, но нет столько времени)
// бинарный поиск в сортированном массиве - понял как работает для одномерного массива, но не понял как для двумерного

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
    arr = SortingLineBubbleArray(arr);
    PrintArray(arr, "Sorting lines of the");
    arr = SortingColumnBubbleArray(arr);
    PrintArray(arr, "Sorting columns of the");
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

int[,] SortingLineBubbleArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            int minPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i,k] < array[i,minPosition]) minPosition = k;
            }
            int temp = array[i,j];
            array[i,j] = array[i,minPosition];
            array[i,minPosition] = temp;
        }
    }
    return array;
}

int[,] SortingColumnBubbleArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0)-1; i++)
        {
            int minPosition = i;
            for (int k = i + 1; k < array.GetLength(0); k++)
            {
                if(array[k,j] < array[minPosition,j]) minPosition = k;
            }
            int temp = array[i,j];
            array[i,j] = array[minPosition,j];
            array[minPosition,j] = temp;
        }
    }
    return array;
}