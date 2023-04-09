// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Main();

void Main()
{
    bool work = true;
    while (work)
    {
        System.Console.WriteLine("Hello! Run the program? y/n");
        string a = Console.ReadLine();
        switch (a)
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
    double[] arr = FillArray(ReadInt("an array length"));
    PrintArray(arr);
    System.Console.WriteLine($"Difference beetween maximum and minimum array elements is {DiffMaxMinOfArray(arr)}.");
}

int ReadInt(string argument)
{
    int number;
    System.Console.WriteLine($"Input {argument}: ");
    while(!int.TryParse(Console.ReadLine(), out number) || number <= 0)
    {
        System.Console.WriteLine("It's not that!");
    }
    return number;
}

double[] FillArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() *(100 - -100) + -100, 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    System.Console.Write("Array: [ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        System.Console.Write(array[i] + "; ");
    }
    System.Console.WriteLine(array[array.Length - 1] + " ].");
}

double DiffMaxMinOfArray(double[] array)
{
    if(array.Length == 1)
    {
        return array[0];
    }
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array [i];
        }
        else if(array[i] < min)
        {
            min = array[i];
        }
    }
    return Math.Round(max - min, 2);
}