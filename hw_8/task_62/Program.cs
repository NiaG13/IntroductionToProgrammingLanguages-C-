// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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
    int height = new Random().Next(2,10);
    int length = new Random().Next(2,10);
    int[,] arr = FillSpiralArray(height, length);
    PrintArray(arr, "Spiral");
}

int[,] FillSpiralArray(int height, int length)
{
    int[,] array = new int [height,length];
    int value = 1;
    int i = 0;
    int j = 0;
    int step = 0;
    (int clm, int str) difference = Diff(height, length);
    int elemInClm = array.GetLength(0);
    int elemInStr = array.GetLength(1);
    while(elemInClm != 1 + difference.clm || elemInStr != 1 + difference.str)
    {
        for (j = step; j < elemInStr; j++)
        {
            array[i,j] = value++;
        }
        j--;
        step++;
        if(Equality(step,elemInClm)) return array;
        for (i = step; i < elemInClm; i++)
        {
            array[i,j] = value++;
        }
        i--;
        step--;
        elemInStr --;
        if(Equality(step,elemInStr)) return array;
        for (j = elemInStr - 1; j >= step; j--)
        {
            array[i,j] = value++;
        }
        j++;
        step++;
        elemInClm--;
        if(Equality(step,elemInClm)) return array;
        for (i = elemInClm - 1; i >= step; i--)
        {
            array[i,j] = value++;
        }
        i++;
        if(Equality(step,elemInStr)) return array;
    }
    return array;
}

bool Equality(int arg1, int arg2)
{
    return arg1 == arg2;
}

(int clm, int str) Diff(int arg1, int arg2)
{
    (int clm, int str) difference = (0, 0);
    if(arg1 == arg2 || arg1 <= 3 || arg2 <= 3)
    {
        difference.clm = 0;
        difference.str = 0;
    }
    else if(arg1 > arg2)
    {
        difference.clm = 0;
        difference.str = 1;
    }
    else
    {
        difference.clm = 1;
        difference.str = 0;
    }
    return difference;
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
